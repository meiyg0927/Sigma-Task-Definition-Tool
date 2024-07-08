using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sigma;
using UISubStep = Sigma.SubStep;

#pragma warning disable IDE1006

namespace SigmaTaskDefinitionUI.UI
{
    public partial class FormVirtualObject : Form
    {
        private VirtualObjectDescriptor _inValue = new();
        private VirtualObjectDescriptor _retValue = new();

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

        public FormVirtualObject()
        {
            InitializeComponent();

            comboBoxModelType.SelectedIndex = 0;
        }

        private void FormVirtualObject_Load(object sender, EventArgs e)
        {
            CenterToParent();

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
        }

        private void buttonVirtualObjectOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBoxModelName.Text))
            {
                MessageBox.Show("请输入虚拟物体描述", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _retValue.ModelType = comboBoxModelType.Text;
                _retValue.Name = richTextBoxModelName.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonVirtualObjectCancel_Click(object sender, EventArgs e)
        {
            _inValue.Name = string.Empty;
            _inValue.ModelType = string.Empty;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
