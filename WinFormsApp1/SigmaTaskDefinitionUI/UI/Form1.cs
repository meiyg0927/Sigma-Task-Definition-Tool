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
        private SigmaTask _task = new SigmaTask();
        private FormOutput frmOutput = new FormOutput();
        private HashSet<string> existingGatherObjects = new HashSet<string>();

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

            //Task.JsonSerialize(); return;

            string taskName = textTaskName.Text.Trim();

            if (_task.setTaskName(taskName))
            {
                if (treeView.Nodes.Count <= 0)
                {
                    TreeNode newNode = new TreeNode(taskName);
                    newNode.ImageIndex = 0;
                    treeView.Nodes.Add(newNode);
                    _task.addStep(); // only for test
                    Debug.WriteLine("Add New Root Node: " + taskName);
                }
                else
                {
                    TreeNode rootNode = treeView.Nodes[0];
                    rootNode.Text = taskName;
                    Debug.WriteLine("Update Root Node: " + taskName);
                }
                textTaskName.Clear();
                _task.Dump();
            }
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            frmOutput.strJson = _task.JsonSerialize();
            if (DialogResult.OK == frmOutput.ShowDialog())
            {
            }
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

        private void buttonMainClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

        private void buttonAddGatherList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxGatherObjectBack.Text)) return;

            string newItem = textBoxGatherObjectBack.Text.Trim();
            if(!existingGatherObjects.Contains(newItem))
            {
                existingGatherObjects.Add(newItem);
                listBoxGatherObject.Items.Add(newItem);
                textBoxGatherObjectBack.Clear();
            }
            else { MessageBox.Show("同样名字的物品已经在列表中","",MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonRemoveGatherList_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxGatherObject.SelectedIndex;
            
            if (selectedIndex >=0 )
            {
                existingGatherObjects.Remove(listBoxGatherObject.Items[selectedIndex].ToString());
                listBoxGatherObject.Items.RemoveAt(selectedIndex);
            }
        }
    }
}
