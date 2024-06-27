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
using System.Text.Json;
using SigmaTaskDefinitionUI;

namespace WinFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        SigmaTask Task = new SigmaTask();

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

            string taskName = textTaskName.Text.Trim();

            if(Task.setTaskName(taskName))
            {
                if(treeView.Nodes.Count <= 0)
                {
                    treeView.Nodes.Add(new TreeNode(taskName));
                    Debug.WriteLine("Add New Root Node: " + taskName);
                }
                else
                {
                    TreeNode rootNode = treeView.Nodes[0];
                    rootNode.Text = taskName;
                    Debug.WriteLine("Update Root Node: " + taskName);
                }
                textTaskName.Clear();

                Task.Dump();
                Task.JsonSerialize();
            }
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("buttonOutput_Click");
        }


        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //MessageBox.Show("treeView_NodeMouseClick: " + e.Node.Text + "  index: " + e.Node.Index);
            if (e.Button == MouseButtons.Left)
            {
                //_index_node_choose = e.Node.Index;
            }
        }

        private void buttonNodeDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("buttonNodeDelete_Click");

            if (treeView.SelectedNode == null) { }
            else
            {
                Debug.WriteLine("Delete Selected Node: " + treeView.SelectedNode.Text);
                treeView.Nodes.RemoveAt(treeView.SelectedNode.Index);
            }
        }
    }
}
