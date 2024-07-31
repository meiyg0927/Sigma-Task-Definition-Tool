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
using System.Windows.Forms.Integration;
using Sigma;
using UISubStep = Sigma.SubStep;

using HelixToolkit.Wpf;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Media.Imaging;

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
                return;
            }

            _isKnownPose = false;
            radioButtonKnownPose.Checked = _isKnownPose;
            radioButtonUnknownPose.Checked = !_isKnownPose;

            if (inValue.SpatialPose != null && inValue.SpatialPose is AtKnownSpatialLocation atkSpatialPose)
            {
                if(!string.IsNullOrWhiteSpace(atkSpatialPose.SpatialLocationName))
                {
                    richTextBoxModelPoseDescription.Text = 
                        atKnowSpatialLocation.SpatialLocationName = atkSpatialPose.SpatialLocationName;
                }
                _isKnownPose= true;
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
                MessageBox.Show("请输入模型描述", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(_isKnownPose && string.IsNullOrWhiteSpace(richTextBoxModelPoseDescription.Text))
            {
                MessageBox.Show("请输入模型位置描述", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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



        #region Tool Functions
        private static void Func_GetStlFiles(out List<string> modelNameList)
        {
            modelNameList = new();
            try
            {
                Debug.WriteLine("=== Get STL models START ==");
                string currentModelDirectory = Directory.GetCurrentDirectory() + "\\Resources\\models";
                string[] stlFiles = Directory.GetFiles(currentModelDirectory, "*.stl");

                foreach (string file in stlFiles)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    Debug.WriteLine(fileName);

                    // 或者将文件名添加到ListBox等控件中显示
                    modelNameList.Add(fileName);
                }

                Debug.WriteLine("=== Get STL models END ==");
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误: " + ex.Message);
            }
        }

        #endregion
    }
}
