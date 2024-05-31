using System;

namespace Matrix
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Island
            /* char[][] mygrid = new char[][] {
               new char[] {'1','1','1','1','0'},
               new char[] {'1','1','0','1','0'},
               new char[] {'0','0','0','0','0'},
               new char[] {'0','0','0','1','1'}
            };
            Solution island = new Solution();


            Console.WriteLine($" Number of island in the grid : {island.NumIslands(mygrid)}"); */

            int[,] matrixtorotate =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            MatrixRotation myrotation = new MatrixRotation();

            Console.WriteLine($"Rotated matrix - {myrotation.CallRotateMatrix(matrixtorotate)}");


        }
    }
}
