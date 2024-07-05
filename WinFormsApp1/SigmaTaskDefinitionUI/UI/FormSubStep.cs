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

namespace SigmaTaskDefinitionUI
{
    public partial class FormSubStep : Form
    {
        private UISubStep _inValue = new UISubStep();
        private UISubStep _retValue = new UISubStep();
        internal UISubStep inValue
        {
            get { return _inValue; }
            set { _inValue = value; }
        }
        internal UISubStep retValue
        {
            get { return _retValue; }
            set { _retValue = value; }
        }

        public FormSubStep()
        {
            InitializeComponent();
        }

        private void FormSubStep_Load(object sender, EventArgs e)
        {
            richTextSubStepDescription.Text = _inValue.Description;
        }

        private void buttonSubStepOK_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(richTextSubStepDescription.Text))
            {
                MessageBox.Show("请输入子任务描述", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            { 
                retValue.Description = richTextSubStepDescription.Text.Trim();
                //richTextSubStepDescription.Text = string.Empty;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonSubStepCancel_Click(object sender, EventArgs e)
        {
            //richTextSubStepDescription.Text = string.Empty;
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
