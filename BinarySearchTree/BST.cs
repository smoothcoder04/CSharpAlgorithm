using System;
//Node that contains left child node & right child node
namespace BinarySearchTree
{
    class Node
    {
        public int value;
        public Node leftChild;
        public Node rightChild;

        public Node()
        {
            value = 0;
            leftChild = null;
            rightChild = null;
        }

        public Node(int val)
        {
            value = val;
            leftChild = null;
            rightChild = null;
        }
    }; 
    //BST class that contains root
    class Bst
    {
        Node root;

        public Bst(int rootValue)
        {
            root = new Node(rootValue);
        }

        public Bst()
        {
            root = null;
        }

        public Node getRoot()
        {
            return root;
        }
        
    }
}

