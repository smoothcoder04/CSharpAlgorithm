using System;
using BinarySearchTree;

namespace BinarySearchTree
{
    class Program
    {
        //find minimum value in the tree
        static public int findMinRecursive(Node root)
        {
            if(root == null)
            {
                return -1;
            }
            else if(root.leftChild == null)
            {
                return root.value;
            }
            else
            {
                return findMinRecursive(root.leftChild);
            }
        }

        static public int findMinIterative(Node root)
        {
            if(root == null)
            {
                return -1;
            }
            while (root.leftChild != null)
            {
                root = root.leftChild;
            }
            return root.value;
        }
        static void Main(string[] args)
        {
            //check if the tree is symmetric
            GFG tree = new GFG();
            int[] arr = {1, 2, 2, 3, 4, 4, 4};
            tree.root = tree.insertLevelOrder(arr, tree.root, 0);
            bool output = tree.isSymmetric();
            if (output == true)
                Console.WriteLine("Symmetric");
            else
                Console.WriteLine("Not symmetric");

            //return root
            BSTFindRoot myroot = new BSTFindRoot(10);
            Console.WriteLine($"The value of the root is {myroot.getRoot().val}");

            
            //BST Insertion iterative
           /*  BSTInsertionIterative BST = new BSTInsertionIterative(13);
            BST.insertBSTIterative(20);
            BST.insertBSTIterative(7);
            BST.insertBSTIterative(16);
            BST.insertBSTIterative(19);
            BST.insertBSTIterative(3);
            BST.insertBSTIterative(1);
            BST.insertBSTIterative(9);
            BST.insertBSTIterative(2);

            Console.WriteLine("InOrderTraversal");
            BST.inOrderPrint(BST.getRoot()); */

            //BST Insertion recursive
            /* BSTInsertionRecursive BSTRec = new BSTInsertionRecursive(13);
            BSTRec.insertBST(4);
            BSTRec.insertBST(7);
            BSTRec.insertBST(16);
            BSTRec.insertBST(19);
            BSTRec.insertBST(3);
            BSTRec.insertBST(1);
            BSTRec.insertBST(9);
            BSTRec.insertBST(2);
            BSTRec.insertBST(5);
            BSTRec.insertBST(15);
            BSTRec.inOrderPrint(BSTRec.getRoot());
 */
            //deletion of leaf node
         BinarySearchTreeDeleteEmptyTree BST = new BinarySearchTreeDeleteEmptyTree(13);
            BST.insertBST(4);
            BST.insertBST(7);
            BST.insertBST(16);
            BST.insertBST(19);
            BST.insertBST(5);
            BST.insertBST(15);

            
            Console.WriteLine("InOrderTraversal");
            BST.inOrderPrint(BST.getRoot());

            Console.WriteLine($"Min value in the tree :{findMinRecursive(BST.getRoot())}");
            Console.WriteLine($"Min value in the tree :{findMinIterative(BST.getRoot())}");


            //Console.WriteLine("Delete 15");
            //Console.WriteLine(BST.deleteBST(15));
            //Console.WriteLine("After deletion");
            //BST.inOrderPrint(BST.getRoot());

/*             BinarySearchTreeMinValue BST = new BinarySearchTreeMinValue(13);
            BST.insertBSTTree(4);
            BST.insertBSTTree(7);
            BST.insertBSTTree(16);
            BST.insertBSTTree(19);
            BST.insertBSTTree(5);
            BST.insertBSTTree(15);

            Console.WriteLine("InOrderTraversal");
            BST.inOrderPrint(BST.getRoot());

            //BST.FindMinValue(); */
            return;
        }
    }
}

