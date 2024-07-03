using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaTaskDefinitionUI.UI
{
    public enum TreeNodeType
    {
        NONE = 0,
        ROOT = 1,
        GATHER = 2,
        DO = 3,
        COMBO = 4,
        SUB = 5
    }

    public enum TaskDataType
    {
        NONE = 0,
        BASIC_TASKNAME = 1,
        BASIC_TASKDESC = 2,
        STEP_GATHER = 3,
    }

    internal class TreeNodeData
    {
        public TreeNodeType Type_TreeNode = TreeNodeType.NONE;
        //public TaskDataType Type_Data = TaskDataType.NONE;
        public int Index_Data = -1;
        public int Index_TreeNode = -1;

        public TreeNodeData() { }
        public TreeNodeData(int index_treenode, TreeNodeType type_TreeNode, int index_data ) 
        { this.Type_TreeNode = type_TreeNode; this.Index_Data = index_data; this.Index_TreeNode = index_treenode; }
    }

    internal class TreeNodeManage
    {
        private static readonly Lazy<TreeNodeManage> _instance = new Lazy<TreeNodeManage>(() => new TreeNodeManage());
        private TreeNodeManage() {}
        public static TreeNodeManage Instance => _instance.Value;

        /// <summary>
        /// 把TreeView的Node 和 TaskData的数据 一对一对应起来
        /// </summary>
        private Dictionary<int, TreeNodeData> _preference = new Dictionary<int, TreeNodeData>();
        private int _root_treenode_index = -1; 

        public bool Add(int TreeNode_Index, TreeNodeType TreeNode_Type, int Task_Index = -1)
        {
            if (TreeNode_Index < 0) return false;

            if (TreeNode_Type == TreeNodeType.ROOT)
            {
                if (_root_treenode_index < 0) { _root_treenode_index = TreeNode_Index; }
                else 
                    return false; //只允许一个Root
            }

            TreeNodeData data = new TreeNodeData(TreeNode_Index, TreeNode_Type, Task_Index);
            _preference.Add(TreeNode_Index, data);

            return true;
        }

        public TreeNodeData? GetRootTreeNode() 
        {
            if(_root_treenode_index < 0) return null;

            TreeNodeData? root = null;
            if(_preference.TryGetValue(_root_treenode_index, out root)) return root;

            return null;
        }
    }
}
