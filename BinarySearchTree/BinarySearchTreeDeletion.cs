namespace BinarySearchTree
{
    public class Node
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
    }
    public class BinarySearchTreeDeleteEmptyTree
    {
        Node root;

        public BinarySearchTreeDeleteEmptyTree(int rootValue)
        {
            //create root of the tree
            root = new Node(rootValue);
        }
        public BinarySearchTreeDeleteEmptyTree()
        {
            //create root of the empty tree
            root = null;
        }
        //method to return root
        public Node getRoot()
        {
            return root;
        }

        //insertion
        public Node insert(Node currentNode, int val)
        {
            if (currentNode == null)
            {
                return new Node(val);
            }
            if(currentNode.value > val)
            {
                currentNode.leftChild = insert(currentNode.leftChild, val);
            }
            else
            {
                currentNode.rightChild = insert(currentNode.rightChild, val);
            }
            return currentNode;
        }
        public void insertBST(int val)
        {
            root = getRoot();
            if (root == null)
            {
              return;  
            }
            insert(root, val);
        }
        //inorder traversal
        public void inOrderPrint(Node currentNode)
        {
            if (currentNode != null)
            {
                inOrderPrint(currentNode.leftChild);
                Console.WriteLine(currentNode.value);
                inOrderPrint(currentNode.rightChild);
            }
        }

        //deletion

        public bool deleteBST(int val)
        {
            return Delete(root, val);
        }

        public bool Delete(Node currentNode, int value)
        {
            if(root == null)
            {
                return false;
            }
            //store parent of currentNode
            Node parent = root;
            //search for the value in the tree. if not found return false
            while(currentNode != null && (currentNode.value != value))
            {
                parent = currentNode;
                if(currentNode.value > value)
                {
                    currentNode = currentNode.leftChild;
                }
                else
                {
                    currentNode = currentNode.rightChild;
                }
            }
            //return the value if the currentNode is not null
            if(currentNode.value == null)
            {
                return false;
            }
            else if((currentNode.leftChild == null) && (currentNode.rightChild == null))
            {
                //This node is a leaf node.

                //check if the leaf node is root
                if (root.value == currentNode.value)
                {
                    root = null;
                    return true;
                }
                else if (currentNode.value < parent.value)
                {
                    parent.leftChild = null;
                    return true;
                }
                else
                {
                    parent.rightChild = null;
                    return true;
                }
            }
            return false;
        }
    }
}