namespace BinarySearchTree
{
    public class BSTInsertionIterative
    {
        TreeNode root;
        public BSTInsertionIterative(int rootValue)
        {
            root = new TreeNode(rootValue);
        }
        public BSTInsertionIterative()
        {
            root = null;
        }
        public TreeNode getRoot()
        {
            return root;
        }

        public void insertBSTIterative(int val)
        {
            if(getRoot() == null)
            {
                root = new TreeNode(val);
                return;
            }

            //startiing from root
            TreeNode currentNode = root;
            TreeNode parent = root;

            while (currentNode != null)
            {
                //update parent
                parent = currentNode;
                if(val < currentNode.val)
                {
                    currentNode = currentNode.left;
                }
                else
                {
                    currentNode = currentNode.right;
                }
            }
            
            if(val < parent.val)
            {
                parent.left = new TreeNode(val);
            }
            else
            {
                parent.right = new TreeNode(val);
            }
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
   
    }
}