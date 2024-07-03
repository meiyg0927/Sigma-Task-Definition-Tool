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
using SigmaTaskDefinitionUI.UI;

namespace WinFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        private SigmaTask sigma_task = new SigmaTask();
        private FormOutput frmOutput = new FormOutput();
        private HashSet<string> existingGatherObjects = new HashSet<string>();

        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonOutput_Click(object sender, EventArgs e)
        {
            frmOutput.strJson = sigma_task.JsonSerialize();
            if (DialogResult.OK == frmOutput.ShowDialog())
            {
            }
        }
        private void buttonMainClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Message Handle for TreeView
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
        #endregion

        #region Message Handle for Tab of Basic
        private void buttonNewTask_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("buttonNewTask_Click");

            string taskName = textTaskName.Text.Trim();

            if (sigma_task.setTaskName(taskName))
            {
                TreeNodeData? root_node = TreeNodeManage.Instance.GetRootTreeNode();

                if (root_node == null)
                {
                    TreeNode newNode = new TreeNode(taskName);
                    newNode.ImageIndex = (int)TreeNodeType.ROOT;
                    int root_index = treeView.Nodes.Add(newNode);
                    TreeNodeManage.Instance.Add(root_index, TreeNodeType.ROOT);

                    Debug.WriteLine("Add New Root Node: " + taskName);
                }
                else 
                {
                    TreeNode rootNode = treeView.Nodes[root_node.Index_TreeNode];
                    rootNode.Text = taskName;
                    Debug.WriteLine("Update Root Node: " + taskName);
                }

                textTaskName.Clear();
            }
        }
        #endregion

        #region Message Handle for Tab of GatherStep
        private void buttonAddGatherList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxGatherObjectBack.Text)) return;

            string newItem = textBoxGatherObjectBack.Text.Trim();
            if (!existingGatherObjects.Contains(newItem))
            {
                existingGatherObjects.Add(newItem);
                listBoxGatherObject.Items.Add(newItem);
                textBoxGatherObjectBack.Clear();
            }
            else { MessageBox.Show("同样名字的物品已经在列表中", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonRemoveGatherList_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxGatherObject.SelectedIndex;

            if (selectedIndex >= 0)
            {
                existingGatherObjects.Remove(listBoxGatherObject.Items[selectedIndex].ToString());
                listBoxGatherObject.Items.RemoveAt(selectedIndex);
            }
        }

        private void buttonAddGatherStep_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
