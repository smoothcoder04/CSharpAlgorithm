using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Bst myBinarySearchTree = new Bst(13);
            Console.WriteLine($"The root of the Binary search tree is {myBinarySearchTree.getRoot().value}");
        }
    }
}

