namespace BinarySearchTree
{
    public class BSTInsertionRecursive
    {
        TreeNode root;
        public BSTInsertionRecursive(int rootValue)
        {
            root = new TreeNode(rootValue);
        }
        public BSTInsertionRecursive()
        {
            root = null;
        }
        public TreeNode getRoot()
        {
            return root;
        }

        public void inOrderPrint(TreeNode currentNode)
        {
            if (currentNode != null)
            {
                inOrderPrint(currentNode.left);
                Console.WriteLine(currentNode.val);
                inOrderPrint(currentNode.right);
            }
        }

        public TreeNode insert(TreeNode currentNode, int val)
        {
            if (currentNode == null)
            {
                return new TreeNode(val);
            }
            else if (currentNode.val > val)
            {
                currentNode.left = insert(currentNode.left, val);
            }
            else
            {
                currentNode.right = insert(currentNode.right, val);
            }
            return currentNode;
        }

        public void insertBST(int value)
        {
            if (getRoot() == null)
            {
                root = new TreeNode(value);
                return;
            }

            insert(this.getRoot(), value);
        }
    }
}
