using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml;
using System.Windows;
using System.Windows.Forms.Integration;
using HelixToolkit.Wpf;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Media.Imaging;

using Sigma;
using UISubStep = Sigma.SubStep;
using System.Windows.Controls;
using System.IO;

#pragma warning disable IDE1006

namespace SigmaTaskDefinitionUI.UI
{
    public partial class FormVirtualObject : Form
    {
        private VirtualObjectDescriptor _inValue = new();
        private VirtualObjectDescriptor _retValue = new();

        private AtKnownSpatialLocation atKnowSpatialLocation = new();

        private bool _isNew = false; //是否是按了Add按钮不是Edit按钮进入的窗体（会影响一些控件的状态）

        private bool _isKnownPose = false;

        internal VirtualObjectDescriptor inValue
        {
            get { return _inValue; }
            set { _inValue = value; }
        }
        internal VirtualObjectDescriptor retValue
        {
            get { return _retValue; }
            set { _retValue = value; }
        }

        internal bool isNew
        {
            get { return this._isNew; }
            set { this._isNew = value; }
        }

        public FormVirtualObject()
        {
            InitializeComponent();

            comboBoxModelType.SelectedIndex = 0;
        }

        private void FormVirtualObject_Load(object sender, EventArgs e)
        {
            CenterToParent();

            {
                Func_GetStlFiles(out List<string> modelNameList);
                comboBoxModelType.Items.Clear();
                foreach (string modelName in modelNameList)
                {
                    comboBoxModelType.Items.Add(modelName);
                }
            }

            richTextBoxModelName.Text = inValue.Name;
            if (comboBoxModelType.Items.Contains(inValue.ModelType))
            {
                int index = comboBoxModelType.Items.IndexOf(inValue.ModelType);
                comboBoxModelType.SelectedIndex = index;
            }
            else
            {
                comboBoxModelType.SelectedIndex = 0;
            }

            if (_isNew)
            {
                _isKnownPose = true;
                radioButtonKnownPose.Checked = _isKnownPose;
                radioButtonUnknownPose.Checked = !_isKnownPose;

                richTextBoxModelPoseDescription.Text = atKnowSpatialLocation.SpatialLocationName = "";
                richTextBoxModelPoseDescription.Enabled = _isKnownPose;


                PresentationTraceSources.DataBindingSource.Switch.Level = SourceLevels.Off;
                InitializeViewport();
                LoadSTLModel(comboBoxModelType.Items[0].ToString());
                //LoadModel();

                return;
            }

            _isKnownPose = false;
            radioButtonKnownPose.Checked = _isKnownPose;
            radioButtonUnknownPose.Checked = !_isKnownPose;

            if (inValue.SpatialPose != null && inValue.SpatialPose is AtKnownSpatialLocation atkSpatialPose)
            {
                if (!string.IsNullOrWhiteSpace(atkSpatialPose.SpatialLocationName))
                {
                    richTextBoxModelPoseDescription.Text =
                        atKnowSpatialLocation.SpatialLocationName = atkSpatialPose.SpatialLocationName;
                }
                _isKnownPose = true;
                radioButtonKnownPose.Checked = _isKnownPose;
                radioButtonUnknownPose.Checked = !_isKnownPose;
            }

            richTextBoxModelPoseDescription.Enabled = _isKnownPose;
        }

        #region Message Handle for Controls

        private void buttonVirtualObjectOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBoxModelName.Text))
            {
                System.Windows.Forms.MessageBox.Show("请输入模型描述", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (_isKnownPose && string.IsNullOrWhiteSpace(richTextBoxModelPoseDescription.Text))
            {
                System.Windows.Forms.MessageBox.Show("请输入模型位置描述", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _retValue.ModelType = comboBoxModelType.Text;
                _retValue.Name = richTextBoxModelName.Text;
                if (_isKnownPose)
                {
                    atKnowSpatialLocation.SpatialLocationName = richTextBoxModelPoseDescription.Text;
                    _retValue.SpatialPose = atKnowSpatialLocation;

                }
                else
                {
                    richTextBoxModelPoseDescription.Text = "";
                    _retValue.SpatialPose = null;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonVirtualObjectCancel_Click(object sender, EventArgs e)
        {
            _inValue.Name = string.Empty;
            _inValue.ModelType = string.Empty;
            _inValue.SpatialPose = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void radioButtonUnknownPose_CheckedChanged(object sender, EventArgs e)
        {
            _isKnownPose = !radioButtonUnknownPose.Checked;
            richTextBoxModelPoseDescription.Enabled = _isKnownPose;
        }

        private void radioButtonKnownPose_CheckedChanged(object sender, EventArgs e)
        {
            _isKnownPose = radioButtonKnownPose.Checked;
            richTextBoxModelPoseDescription.Enabled = _isKnownPose;
        }

        #endregion

        #region 3D Model Preview

        private System.Windows.Forms.Integration.ElementHost? D3_host = null;
        private HelixViewport3D? D3_viewport = null;
        private ModelVisual3D? D3_modelVisual = null;
        private RotateTransform3D? D3_rotateTransform = null;
        private AxisAngleRotation3D? D3_rotation = null;
        private GeometryModel3D? D3_skyboxModel = null;

        private void InitializeViewport()
        {
            D3_viewport = new HelixViewport3D();

            D3_viewport.Camera.Position = new Point3D(3, 3, 3);
            D3_viewport.Camera.LookDirection = new Vector3D(-3, -3, -3);
            D3_viewport.Camera.UpDirection = new Vector3D(0, 1, 0);

            // 移除默认的工具栏和其他UI元素
        #if false
            D3_viewport.ShowViewCube = false;
            D3_viewport.ShowCoordinateSystem = false;
            D3_viewport.ShowFrameRate = false;
            D3_viewport.ShowCameraInfo = false;
            D3_viewport.ShowCameraTarget = false;
            D3_viewport.ShowFieldOfView = false;
            D3_viewport.ShowTriangleCountInfo = false;
            D3_viewport.ShowCameraInfo = false;
        #endif

            // 创建 ElementHost 并将其设置为 PictureBox 的大小和位置
            D3_host = new();
            D3_host.Size = pictureBox.Size;
            D3_host.Location = pictureBox.Location;
            D3_host.Child = D3_viewport;

            this.Controls.Add(D3_host);
            D3_host.BringToFront();
            pictureBox.Visible = false;
        }

        private void LoadModel()
        {
            // 创建立方体
            var builder = new MeshBuilder();
            builder.AddBox(new Point3D(0, 0, 0), 1, 1, 1);
            var geometry = builder.ToMesh();

            var material = new DiffuseMaterial(new SolidColorBrush(Colors.Gray));
            var model = new GeometryModel3D(geometry, material);

            // 创建模型可视化对象
            D3_modelVisual = new ModelVisual3D();
            D3_modelVisual.Content = model;

            // 设置旋转
            D3_rotation = new AxisAngleRotation3D(new Vector3D(0, 1, 0), 0);
            D3_rotateTransform = new RotateTransform3D(D3_rotation);
            D3_modelVisual.Transform = D3_rotateTransform; 

            // 添加点光源
            var pointLight = new PointLight(Colors.White, new Point3D(3, 3, 3));
            var lightVisual = new ModelVisual3D();
            lightVisual.Content = pointLight;

            // 将模型和光源添加到视图
            D3_viewport.Children.Add(D3_modelVisual);
            D3_viewport.Children.Add(lightVisual);
        }

        private void LoadSTLModel(string modelName)
        {
            // 获取应用程序当前目录
            string currentModelDirectory = System.IO.Directory.GetCurrentDirectory() + "\\Resources\\models";
            // 加载 STL 模型
            string filePath = Path.Combine(currentModelDirectory, modelName + ".stl");

            if (System.IO.File.Exists(filePath))
            {
                // 使用 STLReader 加载 STL 文件
                var reader = new StLReader();
                Model3DGroup model = reader.Read(filePath);

                // 获取模型的包围盒
                var bounds = model.Bounds;
                var size = new Vector3D(bounds.SizeX, bounds.SizeY, bounds.SizeZ);
                var maxDimension = Math.Max(Math.Max(size.X, size.Y), size.Z);

                // 计算适当的缩放比例，使最大尺寸适应到特定大小（例如1.0）
                double desiredSize = 2.0;
                double scaleFactor = desiredSize / maxDimension;

                // 创建并应用缩放变换
                var scaleTransform = new ScaleTransform3D(scaleFactor, scaleFactor, scaleFactor);

                // 设置旋转
                //D3_rotation = new AxisAngleRotation3D(new Vector3D(0, 1, 0), 0);
                //D3_rotateTransform = new RotateTransform3D(D3_rotation);

                // 创建一个变换组
                var transformGroup = new Transform3DGroup();
                transformGroup.Children.Add(scaleTransform);
                //transformGroup.Children.Add(D3_rotateTransform);

                // 创建 ModelVisual3D 
                D3_modelVisual = new ModelVisual3D { Content = model };
                D3_modelVisual.Transform = transformGroup;

                // 将模型添加到视口中
                D3_viewport.Children.Clear();
                D3_viewport.Children.Add(D3_modelVisual);

                // 添加点光源
                var pointLight = new PointLight(Colors.White, new Point3D(3, 3, 3));
                var lightVisual = new ModelVisual3D();
                lightVisual.Content = pointLight;

                // 将光源添加到视图
                D3_viewport.Children.Add(lightVisual);

                //D3_viewport.CameraChanged += (s, e) => UpdateSkyboxPosition(); // AdjustSkyboxSize();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show($"文件 {filePath} 不存在");
            }
        }

#endregion

        #region Tool Functions
        private static void Func_GetStlFiles(out List<string> modelNameList)
        {
            modelNameList = new();
            try
            {
                Debug.WriteLine("=== Get STL models START ==");
                string currentModelDirectory = System.IO.Directory.GetCurrentDirectory() + "\\Resources\\models";
                string[] stlFiles = System.IO.Directory.GetFiles(currentModelDirectory, "*.stl");

                foreach (string file in stlFiles)
                {
                    string fileName = System.IO.Path.GetFileNameWithoutExtension(file);
                    Debug.WriteLine(fileName);

                    // 或者将文件名添加到ListBox等控件中显示
                    modelNameList.Add(fileName);
                }

                Debug.WriteLine("=== Get STL models END ==");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("发生错误: " + ex.Message);
            }
        }

        #endregion
    }
}
