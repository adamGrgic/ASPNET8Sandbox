namespace Sandbox.Api.Modules.DSA
{
    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree
    {
        private TreeNode root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            root = InsertRec(root, value);
        }

        private TreeNode InsertRec(TreeNode node, int value)
        {
            if (node == null)
            {
                node = new TreeNode(value);
                return node;
            }

            if (value < node.Value)
            {
                node.Left = InsertRec(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = InsertRec(node.Right, value);
            }

            return node;
        }

        public bool Search(int value)
        {
            return SearchRec(root, value);
        }

        private bool SearchRec(TreeNode node, int value)
        {
            if (node == null)
            {
                return false;
            }

            if (value == node.Value)
            {
                return true;
            }
            else if (value < node.Value)
            {
                return SearchRec(node.Left, value);
            }
            else
            {
                return SearchRec(node.Right, value);
            }
        }

        public void InOrderTraversal()
        {
            InOrderRec(root);
            Console.WriteLine(); // For a new line after traversal
        }

        private void InOrderRec(TreeNode node)
        {
            if (node != null)
            {
                InOrderRec(node.Left);
                Console.Write(node.Value + " ");
                InOrderRec(node.Right);
            }
        }
    }

}
