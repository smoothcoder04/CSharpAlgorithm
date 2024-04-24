using System;

namespace Matrix
{
    public class MatricRecursive
{
    //define the dimensions of the matrix
    public const int N = 3;
    public const int M = 3;

    //Reursive function to traverse the matrix
    public void Traverse(int[,] arr, int i, int j)
    {
        //position is bottom right corner
        if(i == N - 1 && j == M - 1)
        {
            Console.WriteLine($"{arr[i,j]}");
            return;
        }
        //value of the current position
        Console.WriteLine($"Curent Position: {arr[i,j]}");

        //end of current row not being reached
        if(j < M-1)
        {
            //Move right
            Traverse(arr, i, j+1);
        }
        //end of the current column has been reached
        else if(i < N -1)
        {
            //move down to next row
            Traverse(arr, i+1, 0);
        }

    }
}
}
