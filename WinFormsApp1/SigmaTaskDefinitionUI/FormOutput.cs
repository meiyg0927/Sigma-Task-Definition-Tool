using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigmaTaskDefinitionUI
{
    public partial class FormOutput : Form
    {
        public FormOutput()
        {
            InitializeComponent();
        }

        private void FormOutput_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close ();
        }

        public string strJson
        {
            get { return richTextBox.Text; }
            set { richTextBox.Text = value; }
        }
    }
}
