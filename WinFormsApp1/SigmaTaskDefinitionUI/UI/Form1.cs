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
using SigmaTaskDefinitionUI.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        static int NAME_MAX = 40; //step 最长字符数

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

        private void contextMenuStripTreeView_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == null || e.ClickedItem.Name == null) 
                return;

            string item = e.ClickedItem.Name;
            switch (item)
            {
                case "toolStripMenuItemEdit":
                    //MessageBox.Show("Sender: " + sender.ToString() + " Event: toolStripMenuItemEdit");
                    break;
                default:
                    break;
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
                TreeNode? root_node = TreeNodeManage.Instance.GetRootTreeNode();

                if (root_node == null)
                {
                    TreeNode newNode = new TreeNode(taskName);
                    newNode.ImageIndex = newNode.SelectedImageIndex = (int)TreeNodeType.ROOT;
                    int root_index = treeView.Nodes.Add(newNode);
                    TreeNodeManage.Instance.Add(TreeNodeType.ROOT, newNode);

                    Debug.WriteLine("Add New Root Node: " + taskName);
                }
                else
                {
                    TreeNode rootTreeNode = root_node;
                    rootTreeNode.Text = taskName;
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
                string? str = listBoxGatherObject.Items[selectedIndex].ToString();
                if (str != null)
                {
                    existingGatherObjects.Remove(str);
                    listBoxGatherObject.Items.RemoveAt(selectedIndex);
                }
            }
        }

        private void buttonAddGatherStep_Click(object sender, EventArgs e)
        {
            TreeNode? root_node = TreeNodeManage.Instance.GetRootTreeNode();
            if (root_node == null) return;

            if (listBoxGatherObject.Items.Count <= 0)
            {
                MessageBox.Show("请先输入需要收集的物品名字", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //TreeView 增加一个GatherStep节点
            string GatherStepName = "GatherStep: ";
            List<string> Objects = new List<string>();
            for (int i = 0; i < listBoxGatherObject.Items.Count; i++)
            {
                string? obj = listBoxGatherObject.Items[i].ToString();
                if (obj == null) continue;
                GatherStepName += obj + ",";
                Objects.Add(obj);
            }

            TreeNode newNode = new TreeNode();
            if (GatherStepName.Length > NAME_MAX)
            {
                newNode.ToolTipText = GatherStepName; //物体字符太长的话，用Tip来展示
                GatherStepName = GatherStepName.Substring(0, NAME_MAX);
            }
            newNode.Text = GatherStepName;
            newNode.ImageIndex = newNode.SelectedImageIndex = (int)TreeNodeType.GATHER;
            int node_index = root_node.Nodes.Add(newNode);
            root_node.Expand();

            Debug.WriteLine("Add New Gather Node: " + GatherStepName + "  node_index:" + node_index);

            //清空ListBoxGatherObject控件的物体
            listBoxGatherObject.Items.Clear();

            //TaskData增加一条记录
            Step? step = sigma_task.addGatherStep(Objects);

            //TreeNodeData增加一条记录，把TreeView的Node和TaskData的记录关联起来
            TreeNodeManage.Instance.Add(TreeNodeType.GATHER, newNode, step);
        }
        #endregion


    }
}
