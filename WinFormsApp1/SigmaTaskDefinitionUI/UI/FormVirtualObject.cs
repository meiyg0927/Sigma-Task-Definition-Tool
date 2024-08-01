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
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            InitializeRotation();
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

            PresentationTraceSources.DataBindingSource.Switch.Level = SourceLevels.Off;
            InitializeViewport();
            StartRotation();

            richTextBoxModelName.Text = inValue.Name;
            if (comboBoxModelType.Items.Contains(inValue.ModelType))
            {
                int index = comboBoxModelType.Items.IndexOf(inValue.ModelType);
                comboBoxModelType.SelectedIndex = index;
            }
            else
            {
                comboBoxModelType.SelectedIndex = -1;
            }

            //LoadSTLModel(comboBoxModelType.Items[0].ToString());

            if (_isNew)
            {
                _isKnownPose = true;
                radioButtonKnownPose.Checked = _isKnownPose;
                radioButtonUnknownPose.Checked = !_isKnownPose;

                richTextBoxModelPoseDescription.Text = atKnowSpatialLocation.SpatialLocationName = "";
                richTextBoxModelPoseDescription.Enabled = _isKnownPose;

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

        private void FormVirtualObject_FormClosing(object sender, FormClosingEventArgs e)
        {
            //base.OnFormClosing(e);

            StopRotation();
            if (D3_timer != null)
            {
                D3_timer.Tick -= Timer_Tick;
                D3_timer.Dispose();
            }
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

        private void comboBoxModelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 获取当前选中的项
            object? selectedItem = comboBoxModelType.SelectedItem;

            if (selectedItem != null)
            {
                string? selectedModel = selectedItem.ToString();
                if (!string.IsNullOrEmpty(selectedModel))
                {
                    LoadSTLModel(selectedModel);
                }
            }
        }

        private void checkBoxModelAutoRotate_CheckedChanged(object sender, EventArgs e)
        {
            D3_isAutoRotated = checkBoxModelAutoRotate.Checked;
        }

        private void checkBoxAxisVisibled_CheckedChanged(object sender, EventArgs e)
        {
            D3_isAxisVisible = checkBoxAxisVisibled.Checked;

            if (D3_viewport == null) return;

            D3_viewport.ShowCoordinateSystem = D3_isAxisVisible;
        }

        private void checkBoxAuxCubeVisibled_CheckedChanged(object sender, EventArgs e)
        {
            D3_isAuxCubeVisible = checkBoxAuxCubeVisibled.Checked;

            if (D3_viewport == null) return;

            D3_viewport.ShowViewCube = D3_isAuxCubeVisible;
        }

        private void checkBoxModelInfoVisibled_CheckedChanged(object sender, EventArgs e)
        {
            D3_isModelInfoVisible = checkBoxModelInfoVisibled.Checked;

            if (D3_viewport == null) return;

            D3_viewport.ShowFrameRate = D3_isModelInfoVisible;
            D3_viewport.ShowTriangleCountInfo = D3_isModelInfoVisible;
        }

        #endregion

        #region 3D Model Preview

        private System.Windows.Forms.Integration.ElementHost? D3_host = null;
        private HelixViewport3D? D3_viewport = null;
        private ModelVisual3D? D3_modelVisual = null;
        private RotateTransform3D? D3_rotateTransform = null;
        private AxisAngleRotation3D? D3_rotation = null;
        private GeometryModel3D? D3_skyboxModel = null;
        private System.Windows.Forms.Timer? D3_timer = null;
        private bool D3_isAutoRotated = false;
        private bool D3_isAxisVisible = false;
        private bool D3_isAuxCubeVisible = true;
        private bool D3_isModelInfoVisible = false;

        private readonly int TIMER_INTERVAL = 50; //模型旋转周期 // 50ms, 即每秒20帧

        private void InitializeViewport()
        {
            //此函数在Form_Load被调用，会造成每次打开窗体就分配一堆内存!
            D3_viewport = new HelixViewport3D();

            D3_viewport.Camera.Position = new Point3D(3, 3, 3);
            D3_viewport.Camera.LookDirection = new Vector3D(-3, -3, -3);
            D3_viewport.Camera.UpDirection = new Vector3D(0, 1, 0);

            // 移除默认的工具栏和其他UI元素
            D3_viewport.ShowViewCube = D3_isAuxCubeVisible;
            D3_viewport.ShowCoordinateSystem = D3_isAxisVisible;
            D3_viewport.ShowFrameRate = D3_isModelInfoVisible;
            D3_viewport.ShowTriangleCountInfo = D3_isModelInfoVisible;

            D3_viewport.ShowFieldOfView = false;
            D3_viewport.ShowCameraInfo = false;
            D3_viewport.ShowCameraInfo = false;
            D3_viewport.ShowCameraTarget = false;

            // 创建 ElementHost 并将其设置为 PictureBox 的大小和位置
            D3_host = new();
            D3_host.Size = pictureBox.Size;
            D3_host.Location = pictureBox.Location;
            D3_host.Child = D3_viewport;

            this.Controls.Add(D3_host);
            D3_host.BringToFront();
            pictureBox.Visible = false;

            // 创建 ModelVisual3D
            D3_modelVisual = new();
            // 将模型添加到视口中
            D3_viewport.Children.Add(D3_modelVisual);

            // 添加点光源
            var pointLight = new PointLight(Colors.White, new Point3D(3, 3, 3));
            var lightVisual = new ModelVisual3D();
            lightVisual.Content = pointLight;

            // 将光源添加到视图
            D3_viewport.Children.Add(lightVisual);

            // 设置旋转
            D3_rotation = new AxisAngleRotation3D(new Vector3D(0, 1, 0), 0);
            D3_rotateTransform = new RotateTransform3D(D3_rotation);
        }

        private void LoadSTLModel(string modelName)
        {
            if (D3_viewport == null || D3_modelVisual == null || string.IsNullOrWhiteSpace(modelName)) return;

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

                // 创建一个变换组
                var transformGroup = new Transform3DGroup();
                transformGroup.Children.Add(scaleTransform);
                transformGroup.Children.Add(D3_rotateTransform);

                D3_modelVisual.Content = model;
                D3_modelVisual.Transform = transformGroup;

                //D3_viewport.CameraChanged += (s, e) => UpdateSkyboxPosition(); // AdjustSkyboxSize();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show($"文件 {filePath} 不存在");
            }
        }

        private void InitializeRotation()
        {
            D3_timer = new();
            D3_timer.Interval = TIMER_INTERVAL;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (D3_viewport == null || D3_rotation == null || D3_timer == null) return;

            if (!D3_isAutoRotated) return;
            D3_rotation.Angle += 1; // 每帧旋转1度
            if (D3_rotation.Angle >= 360)
                D3_rotation.Angle = 0;
            D3_viewport?.InvalidateVisual();
        }

        private void StartRotation()
        {
            if (D3_viewport == null || D3_rotation == null || D3_timer == null) return;

            D3_timer.Tick += Timer_Tick;

            // 确保 Timer 没有在运行
            if (!D3_timer.Enabled)
            {
                D3_timer.Start();
            }
        }

        private void StopRotation()
        {
            D3_timer?.Stop();
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
