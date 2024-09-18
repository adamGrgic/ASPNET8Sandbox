

namespace Sandbox.Api.Modules.DataStructuresAndAlgorithms.BinarySearchTree
{
    public interface IBinarySearchTree
    {
        void Insert(int value);
        bool Search(int value);
        List<int> InOrderTraversal();
        TreeNode GetTree();
        (List<int> Traversal, bool SearchResult, TreeNode Tree) ExecuteTreeOperations(int[] valuesToInsert, int valueToSearch);
    }
}
