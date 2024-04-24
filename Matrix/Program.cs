using System;

namespace Matrix
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3}, { 4, 5, 6,}, { 7, 8, 9}};
            //start traversal from top left corner
            MatricRecursive myMatrix = new MatricRecursive();
            myMatrix.Traverse(arr, 0, 0);
        }
    }
}
