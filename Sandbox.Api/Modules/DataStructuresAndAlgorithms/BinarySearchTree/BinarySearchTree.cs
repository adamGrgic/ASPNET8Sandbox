namespace Sandbox.Api.Modules.DataStructuresAndAlgorithms.BinarySearchTree
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree : IBinarySearchTree
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

        public List<int> InOrderTraversal()
        {
            var result = new List<int>();
            InOrderRec(root, result);
            return result;
        }

        private void InOrderRec(TreeNode node, List<int> result)
        {
            if (node != null)
            {
                InOrderRec(node.Left, result);
                result.Add(node.Value);
                InOrderRec(node.Right, result);
            }
        }

        public TreeNode GetTree()
        {
            return root;
        }

        // New method to execute all operations and return results
        public (List<int> Traversal, bool SearchResult, TreeNode Tree) ExecuteTreeOperations(int[] valuesToInsert, int valueToSearch)
        {
            // Step 1: Insert values
            foreach (var value in valuesToInsert)
            {
                Insert(value);
            }

            // Step 2: Search for a value
            bool searchResult = Search(valueToSearch);

            // Step 3: Perform in-order traversal
            List<int> traversal = InOrderTraversal();

            // Step 4: Return the entire tree structure
            TreeNode tree = GetTree();

            return (traversal, searchResult, tree);
        }
    }


}
