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
        COMPLEX = 4,
        SUB = 5
    }

    internal class TreeNodeData
    {
        public TreeNodeType type = TreeNodeType.NONE;
        public TreeNode? node = null;
        public Step? step = null;
        public SubStep? subStep = null;

        public TreeNodeData() { }
        public TreeNodeData(TreeNodeType Type, TreeNode? Node, Step? Stp, SubStep? Substp) 
        { this.type = Type; this.node = Node; this.step = Stp; this.subStep = Substp; }
    }

    internal class TreeNodeManage
    {
        private static readonly string error_message_title = "TreeNodeManage ERROR!!!  ERROR!!! ERROR!!!\n";

        private static readonly Lazy<TreeNodeManage> _instance = new Lazy<TreeNodeManage>(() => new TreeNodeManage());
        private TreeNodeManage() {}
        public static TreeNodeManage Instance => _instance.Value;

        // 把TreeView的Node 和 TaskData的数据 一对一对应起来; 根节点直接保存，不加入Dictionary，因为没有Step数据；
        // 注意：SubStep也会记录在Dictionary里面，这点和TaskData不一样；
        private readonly Dictionary<TreeNode, TreeNodeData> _dict = new();
        private TreeNode? root_node = null;

        public bool Add(TreeNodeType Type, TreeNode? Node, Step? Stp = null, SubStep? Substp = null)
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
                TreeNodeData data = new(Type, Node, Stp, Substp);
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

        public bool RemoveAllNodes()
        {
            root_node = null;
            _dict.Clear();

            return true;
        }

        public bool RemoveNode(TreeNode? Node, TreeNodeType NodeType)
        {
            if(Node == null) return false;
            try
            {
                //if(TreeNodeType.COMPLEX == NodeType) //需要在UI层先删除下面的SUB节点的关联
                //{
                //}
                
                return _dict.Remove(Node);
            }
            catch (ArgumentException ex)
            {
                Debug.WriteLine(error_message_title + ex.Message);
                return false;
            }
        }
    }
}
