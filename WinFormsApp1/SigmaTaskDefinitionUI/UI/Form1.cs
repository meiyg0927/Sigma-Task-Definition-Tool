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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Sigma;
using SigmaTaskDefinitionUI;
using SigmaTaskDefinitionUI.Data;
using UISubStep = Sigma.SubStep;
using System.Security.Cryptography;
using System.Reflection.Metadata.Ecma335;

#pragma warning disable IDE1006
#pragma warning disable IDE0028
#pragma warning disable IDE0029

namespace WinFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        readonly int NAME_MAX = 40; //TreeView控件显示的 Step 最长字符数
        readonly int NAME_SUBSTP_MAX = 20; //listBoxSubStep控件显示的 SubStep 最长字符数

        private readonly SigmaTask sigma_task = new();
        private readonly FormOutput frmOutput = new();
        private readonly FormSubStep frmSubStep = new();

        private readonly HashSet<string> existingGatherObjects = new();// HashSet<string>();
        private readonly List<UISubStep> SubStepDataList = new();// List<UISubStep>();

        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimeDoDuring.Value = dateTimeDoDuring.MinDate;

            buttonUpdateGatherStep.Visible = false;
            buttonUpdateDoStep.Visible = false;
        }
        private void buttonOutput_Click(object sender, EventArgs e)
        {
            sigma_task.CalculateLabel();
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
                TreeNode? root_node = TreeNodeManage.Instance.GetRootTreeNode();
                if (root_node == null) return;
                if (treeView.SelectedNode == root_node) //删除根节点
                {
                    treeView.Nodes.RemoveAt(treeView.SelectedNode.Index);
                    sigma_task.Initialize();
                    TreeNodeManage.Instance.RemoveAllNodes();

                    Debug.WriteLine("Delete Root Node");
                }
                else //删除普通节点
                {
                    TreeNodeData? data = TreeNodeManage.Instance.GetTreeNodeData(treeView.SelectedNode);
                    if (data != null && data.node != null)
                    {
                        if (data.type == TreeNodeType.SUB) //子任务节点删除后需要通知父ComplexStep节点
                        {
                            TreeNodeData? parent_data = TreeNodeManage.Instance.GetTreeNodeData(data.node.Parent);
                            if (parent_data != null)
                            {
                                sigma_task.RemoveSubStep(parent_data.step, data.subStep);
                            }
                            TreeNodeManage.Instance.RemoveNode(data.node, TreeNodeType.SUB);

                            data.node.Remove();

                            //如果最后一个子任务节点删除了，是否需要删除父ComplexStep节点？
                            if (parent_data != null && parent_data.node != null && parent_data.node.Nodes.Count <= 0)
                            {
                                MessageBox.Show("子任务节点全部删除了");
                            }
                        }
                        else
                        if (data.type == TreeNodeType.COMPLEX) //复杂任务节点需要删除下面的所有子任务节点
                        {
                            //删除下面所有子节点和子任务的关联
                            foreach (TreeNode child_node in data.node.Nodes)
                            {
                                TreeNodeManage.Instance.RemoveNode(child_node, TreeNodeType.SUB);
                            }
                            //删除子节点
                            data.node.Nodes.Clear();

                            root_node.Nodes.Remove(data.node);
                            sigma_task.RemoveStep(data.step);
                            TreeNodeManage.Instance.RemoveNode(data.node, TreeNodeType.COMPLEX);
                        }
                        else
                        {
                            root_node.Nodes.Remove(data.node);
                            sigma_task.RemoveStep(data.step);
                            TreeNodeManage.Instance.RemoveNode(data.node, data.type);
                        }

                        Debug.WriteLine("Delete Normal Node: " + data.type.ToString());
                    }
                }
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
                    {
                        TreeNode? root_node = TreeNodeManage.Instance.GetRootTreeNode();
                        if (root_node == null) break;

                        if (treeView.SelectedNode == root_node)
                        {
                            tabControlTask.SelectedIndex = 0;
                            Func_ContextMenuHandle_EditBegin(null);
                        }
                        else
                        {
                            TreeNodeData? treeNodeData = TreeNodeManage.Instance.GetTreeNodeData(treeView.SelectedNode);
                            if (treeNodeData == null) { return; }

                            if (treeNodeData.type == TreeNodeType.SUB)
                            {
                                frmSubStep.ShowDialog();
                            }
                            else
                            {
                                tabControlTask.SelectedIndex = (int)treeNodeData.type - 1;
                            }
                            Func_ContextMenuHandle_EditBegin(treeNodeData);
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        //根据需要编辑的Step类型给各个控件赋值
        private void Func_ContextMenuHandle_EditBegin(TreeNodeData? node_data)
        {
            if (node_data == null) //root node will be edited
            {
                //TreeNode? root_node = TreeNodeManage.Instance.GetRootTreeNode();
                textTaskName.Text = sigma_task.getTaskName();
            }
            else
            {
                if (node_data.type == TreeNodeType.SUB)
                {
                    return;
                }

                if (node_data.type == TreeNodeType.COMPLEX)
                {
                    return;
                }

                if (node_data.type == TreeNodeType.GATHER)
                {
                    if (node_data.step is GatherStep stepG)
                    {
                        //清空ListBoxGatherObject控件的物体和之前保存的物体名称
                        textBoxGatherObjectBack.Text = string.Empty;
                        listBoxGatherObject.Items.Clear();
                        existingGatherObjects.Clear();

                        buttonUpdateGatherStep.Visible = true;

                        foreach (string obj in stepG.Objects)
                        {
                            listBoxGatherObject.Items.Add(obj);
                            existingGatherObjects.Add(obj);
                        }
                    }
                    return;
                }

                if (node_data.type == TreeNodeType.DO)
                {
                    if (node_data.step is DoStep stepD)
                    {
                        buttonUpdateDoStep.Visible = true;

                        dateTimeDoDuring.Value = dateTimeDoDuring.MinDate.Add(stepD.TimerDuration);
                        richTextDoDescription.Text = stepD.Description;
                    }
                    return;
                }
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
                    TreeNode newNode = new(taskName);
                    newNode.ImageIndex = newNode.SelectedImageIndex = (int)TreeNodeType.ROOT;
                    treeView.Nodes.Add(newNode);
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
            if (string.IsNullOrWhiteSpace(textBoxGatherObjectBack.Text)) return;

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
            if (listBoxGatherObject.Items.Count <= 0)
            {
                MessageBox.Show("请先输入需要收集的物品名字", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Func_AddorUpdateGatherStep(null);
        }

        private void buttonUpdateGatherStep_Click(object sender, EventArgs e)
        {
            if (listBoxGatherObject.Items.Count <= 0)
            {
                MessageBox.Show("请先输入需要收集的物品名字", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Func_AddorUpdateGatherStep(treeView.SelectedNode);

            buttonUpdateGatherStep.Visible = false;
        }

        private void Func_AddorUpdateGatherStep(TreeNode? tree_node)
        {
            TreeNode? root_node = TreeNodeManage.Instance.GetRootTreeNode();
            if (root_node == null) return;

            string GatherStepName = "GatherStep: ";
            List<string> Objects = new();
            for (int i = 0; i < listBoxGatherObject.Items.Count; i++)
            {
                string? obj = listBoxGatherObject.Items[i].ToString();
                if (obj == null) continue;
                GatherStepName += obj + ",";
                Objects.Add(obj);
            }

            bool isNew = (tree_node == null);
            TreeNode newNode = (tree_node == null) ? new() : tree_node;
            if (GatherStepName.Length > NAME_MAX)
            {
                newNode.ToolTipText = GatherStepName; //物体字符太长的话，用Tip来展示
                GatherStepName = GatherStepName.Substring(0, NAME_MAX);
            }

            //TreeNode状态更新
            newNode.Text = GatherStepName;
            newNode.ImageIndex = newNode.SelectedImageIndex = (int)TreeNodeType.GATHER;

            if (isNew)//TreeView 增加一个GatherStep节点
            {
                int node_index = root_node.Nodes.Add(newNode);
                root_node.Expand();
                Debug.WriteLine("Add New GatherStep Node: " + GatherStepName + "  node_index:" + node_index);

                //TaskData增加一条记录
                Step? step = sigma_task.addGatherStep(Objects);

                //TreeNodeData增加一条记录，把TreeView的Node和TaskData的记录关联起来
                TreeNodeManage.Instance.Add(TreeNodeType.GATHER, newNode, step);
            }
            else
            {
                //TaskData更新一条记录
                TreeNodeData? data = TreeNodeManage.Instance.GetTreeNodeData(tree_node);
                if (data != null)
                {
                    sigma_task.updateGatherStep(data.step, Objects);
                }

                Debug.WriteLine("Update GatherStep Node: " + GatherStepName + "  node_index:" + newNode.Index);
            }

            //清空ListBoxGatherObject控件的物体和之前保存的物体名称
            textBoxGatherObjectBack.Text = string.Empty;
            listBoxGatherObject.Items.Clear();
            existingGatherObjects.Clear();
        }
        #endregion

        #region Message Handle for Tab of DoStep
        private void buttonAddDoStep_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimeDoDuring.Value;
            TimeSpan span = dt.Subtract(dateTimeDoDuring.MinDate);

            if (span.TotalHours >= 24)
            {
                MessageBox.Show("请设置小于一天的任务执行时间", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (span.TotalSeconds <= 0)
            {
                MessageBox.Show("请设置任务执行的时间", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(richTextDoDescription.Text))
            {
                MessageBox.Show("请输入任务描述", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Func_AddorUpdateDoStep(span,null);
        }

        private void buttonUpdateDoStep_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimeDoDuring.Value;
            TimeSpan span = dt.Subtract(dateTimeDoDuring.MinDate);

            if (span.TotalHours >= 24)
            {
                MessageBox.Show("请设置小于一天的任务执行时间", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (span.TotalSeconds <= 0)
            {
                MessageBox.Show("请设置任务执行的时间", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(richTextDoDescription.Text))
            {
                MessageBox.Show("请输入任务描述", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Func_AddorUpdateDoStep(span, treeView.SelectedNode);

            buttonUpdateDoStep.Visible = false;
        }

        private void Func_AddorUpdateDoStep(TimeSpan span, TreeNode? tree_node) 
        {
            TreeNode? root_node = TreeNodeManage.Instance.GetRootTreeNode();
            if (root_node == null) return;

            bool isNew = (tree_node == null);
            TreeNode newNode = (tree_node == null) ? new() : tree_node;            
            string DoStepName = "DoStep: " + span.ToString() + " Desption: " + richTextDoDescription.Text;
            if (DoStepName.Length > NAME_MAX)
            {
                newNode.ToolTipText = DoStepName; //物体字符太长的话，用Tip来展示
                DoStepName = DoStepName.Substring(0, NAME_MAX);
            }

            //TreeNode状态更新
            newNode.Text = DoStepName;
            newNode.ImageIndex = newNode.SelectedImageIndex = (int)TreeNodeType.DO;

            if (isNew)//TreeView 增加一个DoStep节点
            {
                int node_index = root_node.Nodes.Add(newNode);
                root_node.Expand();

                Debug.WriteLine("Add New DoStep Node: " + DoStepName + "  node_index:" + node_index);

                //TaskData增加一条记录
                Step? step = sigma_task.addDoStep(richTextDoDescription.Text, span);

                //TreeNodeData增加一条记录，把TreeView的Node和TaskData的记录关联起来
                TreeNodeManage.Instance.Add(TreeNodeType.DO, newNode, step);
            }
            else
            {
                //TaskData更新一条记录
                TreeNodeData? data = TreeNodeManage.Instance.GetTreeNodeData(tree_node);
                if (data != null)
                {
                    sigma_task.updateDoStep(data.step, richTextDoDescription.Text, span);
                }

                Debug.WriteLine("Update DoStep Node: " + DoStepName + "  node_index:" + newNode.Index);

            }

            //DataTimePicker控件时间归零，执行任务的描述控件清空
            dateTimeDoDuring.Value = dateTimeDoDuring.MinDate;
            richTextDoDescription.Text = string.Empty;
        }

        #endregion

        #region Message Handle for Tab of Complex Step
        private void buttonAddComplexStep_Click(object sender, EventArgs e)
        {
            TreeNode? root_node = TreeNodeManage.Instance.GetRootTreeNode();
            if (root_node == null) return;

            if (string.IsNullOrWhiteSpace(richTextComplexDescription.Text))
            {
                MessageBox.Show("请输入任务描述", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (SubStepDataList.Count <= 0)
            {
                MessageBox.Show("请先添加子任务", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //TreeView 增加一个ComplexStep节点
            string ComplexStepName = "ComplexStep: " + richTextComplexDescription.Text;
            TreeNode newNode = new();
            if (ComplexStepName.Length > NAME_MAX)
            {
                newNode.ToolTipText = ComplexStepName; //物体字符太长的话，用Tip来展示
                ComplexStepName = ComplexStepName.Substring(0, NAME_MAX);
            }
            newNode.Text = ComplexStepName;
            newNode.ImageIndex = newNode.SelectedImageIndex = (int)TreeNodeType.COMPLEX;
            root_node.Nodes.Add(newNode);
            root_node.Expand();

            //TaskData增加一条记录
            Step? step = sigma_task.addComplexStep(richTextComplexDescription.Text, SubStepDataList);

            //TreeNodeData增加一条记录，把TreeView的Node和TaskData的记录关联起来
            TreeNodeManage.Instance.Add(TreeNodeType.COMPLEX, newNode, step);

            //TreeView 增加SubSteps节点
            {
                Func_AddSubSteps(newNode, step);
            }

            //清空子任务列表；复杂任务的描述控件清空
            listBoxSubStep.Items.Clear();
            richTextComplexDescription.Text = string.Empty;
            SubStepDataList.Clear();
        }
        private void buttonAddSubStep_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == frmSubStep.ShowDialog())
            {
                UISubStep data = frmSubStep.retValue.Clone();
                SubStepDataList.Add(data);

                string str = frmSubStep.retValue.Description;
                if (str.Length > NAME_SUBSTP_MAX) str = str.Substring(0, NAME_SUBSTP_MAX);
                listBoxSubStep.Items.Add(str);
            }
        }

        private void buttonRemoveSubStep_Click(object sender, EventArgs e)
        {
            if (listBoxSubStep.SelectedItem != null)
            {
                SubStepDataList.RemoveAt(listBoxSubStep.SelectedIndex);
                listBoxSubStep.Items.RemoveAt(listBoxSubStep.SelectedIndex);
            }
        }

        private void buttonEditSubStep_Click(object sender, EventArgs e)
        {
            if (listBoxSubStep.SelectedItem != null)
            {
                int SelectedIndex = listBoxSubStep.SelectedIndex;

                frmSubStep.inValue.Copy(SubStepDataList.ElementAt(SelectedIndex));
                if (DialogResult.OK == frmSubStep.ShowDialog())
                {
                    UISubStep updated_data = frmSubStep.retValue.Clone();
                    SubStepDataList[SelectedIndex] = updated_data;

                    string updated_str = frmSubStep.retValue.Description;
                    if (updated_str.Length > NAME_SUBSTP_MAX) updated_str = updated_str.Substring(0, NAME_SUBSTP_MAX);
                    listBoxSubStep.Items[SelectedIndex] = updated_str;
                }
            }
            else { MessageBox.Show("请先点选一个子任务再选择编辑", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void buttonSubStepMoveUp_Click(object sender, EventArgs e)
        {
            int SelectedIndex = listBoxSubStep.SelectedIndex;
            Func_MoveListBoxItemOptimized(listBoxSubStep, SelectedIndex, SelectedIndex - 1);
            Func_MoveUISubStepDataInList(SelectedIndex, SelectedIndex - 1);
        }
        private void buttonSubStepMoveDown_Click(object sender, EventArgs e)
        {
            int SelectedIndex = listBoxSubStep.SelectedIndex;
            Func_MoveListBoxItemOptimized(listBoxSubStep, SelectedIndex, SelectedIndex + 1);
            Func_MoveUISubStepDataInList(SelectedIndex, SelectedIndex + 1);
        }

        private void Func_AddSubSteps(TreeNode parent_node, Step? complex_step)
        {
            for (int i = 0; i < SubStepDataList.Count; i++)
            {
                UISubStep step = SubStepDataList[i];

                //TreeView 增加一个SubStep节点
                string SubStepName = "SubStep: " + step.Description;
                TreeNode newNode = new();
                if (SubStepName.Length > NAME_MAX)
                {
                    newNode.ToolTipText = SubStepName; //物体字符太长的话，用Tip来展示
                    SubStepName = SubStepName.Substring(0, NAME_MAX);
                }
                newNode.Text = SubStepName;
                newNode.ImageIndex = newNode.SelectedImageIndex = (int)TreeNodeType.SUB;
                parent_node.Nodes.Add(newNode);
                parent_node.Expand();

                //TaskData中不需要增加SubStep记录

                //TreeNodeData增加一条记录，把TreeView的Node和SubStep的记录关联起来
                if (complex_step is ComplexStep stepC)
                {
                    TreeNodeManage.Instance.Add(TreeNodeType.SUB, newNode, complex_step, stepC.SubSteps[i]);
                }
                else
                {
                    MessageBox.Show("出错了：子任务的父节点无法转换为ComplexStep", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void Func_MoveUISubStepDataInList(int fromIndex, int toIndex)
        {
            if (fromIndex < 0 || fromIndex >= SubStepDataList.Count || toIndex < 0 || toIndex >= SubStepDataList.Count)
            {
                return;
            }

            UISubStep selectedItem = SubStepDataList.ElementAt(fromIndex);
            SubStepDataList.RemoveAt(fromIndex);
            SubStepDataList.Insert(toIndex, selectedItem);
        }

        #endregion

        private void Func_MoveListBoxItemOptimized(ListBox listBox, int fromIndex, int toIndex)
        {
            if (fromIndex < 0 || fromIndex >= listBox.Items.Count || toIndex < 0 || toIndex >= listBox.Items.Count)
            {
                return;
            }

            int selectedIndex = listBox.SelectedIndex;
            listBox.SuspendLayout();
            listBox.BeginUpdate();

            object selectedItem = listBox.Items[fromIndex];
            listBox.Items.RemoveAt(fromIndex);
            listBox.Items.Insert(toIndex, selectedItem);

            if (selectedIndex == fromIndex)
            {
                selectedIndex = toIndex;
            }
            else if (selectedIndex > fromIndex)
            {
                selectedIndex--;
            }

            listBox.SetSelected(selectedIndex, true);
            listBox.EndUpdate();
            listBox.ResumeLayout();
        }
    }
}
