using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNewTask_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("buttonNewTask_Click");
            treeView.Nodes.Add(new TreeNode(textTaskName.Text));
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("buttonOutput_Click");
        }
    }
}
