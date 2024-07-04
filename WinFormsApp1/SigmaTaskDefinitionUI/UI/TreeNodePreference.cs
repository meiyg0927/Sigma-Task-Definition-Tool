using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sigma;

namespace SigmaTaskDefinitionUI.Data
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
        public TreeNodeType type = TreeNodeType.NONE;
        public TreeNode? node = null;
        public Step? step = null;

        public TreeNodeData() { }
        public TreeNodeData(TreeNodeType Type, TreeNode? Node, Step? Stp) 
        { this.type = Type; this.node = Node; this.step = Stp; }
    }

    internal class TreeNodeManage
    {
        static string error_message_title = "TreeNodeManage ERROR!!!  ERROR!!! ERROR!!!\n";

        private static readonly Lazy<TreeNodeManage> _instance = new Lazy<TreeNodeManage>(() => new TreeNodeManage());
        private TreeNodeManage() {}
        public static TreeNodeManage Instance => _instance.Value;

        /// <summary>
        /// 把TreeView的Node 和 TaskData的数据 一对一对应起来
        /// </summary>
        private Dictionary<TreeNode, TreeNodeData> _dict = new Dictionary<TreeNode, TreeNodeData>();
        private TreeNode? root_node = null;

        public bool Add(TreeNodeType Type, TreeNode? Node, Step? Stp = null)
        {
            if (Node == null) return false;

            if (Type == TreeNodeType.ROOT)
            {
                if (root_node == null) { root_node = Node; }
                else
                    return false; //只允许一个Root
            }
            else
            {
                TreeNodeData data = new TreeNodeData(Type, Node, Stp);
                try
                {
                    _dict.Add(Node, data);
                }
                catch(ArgumentException ex) 
                {
                    Debug.WriteLine(error_message_title + ex.Message);
                    return false;
                }            
            }

            return true;
        }

        public TreeNode? GetRootTreeNode()
        {
            return root_node;
        }

        public TreeNodeData? GetTreeNodeData(TreeNode? Node) 
        {
            if (Node == null) return null;

            TreeNodeData? NodeData = null;

            try
            {
                _dict.TryGetValue(Node, out NodeData);
            }
            catch (ArgumentException ex)
            {
                Debug.WriteLine(error_message_title + ex.Message);
            }

            return NodeData;
        }
    }
}
