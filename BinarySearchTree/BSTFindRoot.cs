namespace BinarySearchTree
{
    public class BSTFindRoot
    {
        TreeNode root;
        public BSTFindRoot(int rootVal)
        {
            root = new TreeNode(rootVal);
        }
        public BSTFindRoot()
        {
            root = null;
        }
        public TreeNode getRoot()
        {
            return root;
        }
    }
}