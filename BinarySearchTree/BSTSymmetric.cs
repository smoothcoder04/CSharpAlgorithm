using System;
using System.Collections;

//Node that contains left child node & right child node
namespace BinarySearchTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int item)
        {
            this.val = item;
            this.left = null;
            this.right = null;
        }
    }

    public class GFG
    {
        public TreeNode root;
        public TreeNode insertLevelOrder(int[] arr, TreeNode root, int i)
            {
                if (i < arr.Length)
                {
                    TreeNode temp = new TreeNode(arr[i]);
                    root = temp;
        
                    // Insert left child
                    root.left = insertLevelOrder(arr,
                        root.left, 2 * i + 1);
        
                    // Insert right child
                    root.right = insertLevelOrder(arr,
                        root.right, 2 * i + 2);
                }
        
                return root;
            }
        
            bool isMirror(TreeNode node1, TreeNode node2)
            {
                // if both trees are empty, they are mirror image
                if (node1 == null && node2 == null)
                    return true;
        
               
                if (node1 != null && node2 != null
                                  && node1.val == node2.val)
                    return (isMirror(node1.left, node2.right)
                            && isMirror(node1.right, node2.left));
        
                // if none of the above conditions
                // is true then root1 and root2 are
                // mirror images
                return false;
            }

            public bool isSymmetric()
            {
                // check if tree is mirror of itself
                return isMirror(root, root);
            }
    }
    

}