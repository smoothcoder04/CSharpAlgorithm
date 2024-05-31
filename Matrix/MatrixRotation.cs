using System;

namespace Matrix
{
    public class MatrixRotation
    {
        public void Rotate(int i, int j, int[,] E, int[,] grid, int layer, int m, int n)
        {

            while (E[0 + layer, 0 + layer] == 0)
            {

                if (j + 1 < n - layer && i == 0 + layer)
                {
                    E[i, j + 1] = grid[i, j];
                    j = j + 1;
                    continue;
                }

                if (i + 1 < m - layer && j == n - layer - 1)
                {
                    E[i + 1, j] = grid[i, j];
                    i = i + 1;
                    continue;
                }
                if (j - 1 >= 0 + layer && i == m - layer - 1)
                {
                    E[i, j - 1] = grid[i, j];
                    j = j - 1;
                    continue;
                }
                if (i - 1 >= 0 + layer && j == 0 + layer)
                {
                    E[i - 1, j] = grid[i, j];
                    i = i - 1;
                    continue;
                }

            }

        }

        public int[,] CallRotateMatrix(int[,] grid)
        {
            int[,] E = new int[grid.GetLength(0), grid.GetLength(1)];
            int m = grid.GetLength(0);
            int n = grid.GetLength(1);
            int layer = 0;
            int ii = 0;
            int jj = 0;

            Rotate(ii, jj, E, grid, layer, m, n);
            layer++;

            E[layer, layer] = grid[layer, layer];


            // Print the elements of the array E
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(E[i, j] + " ");
                }
                Console.WriteLine(); // Move to the next line after each row
            }
            return E;
        }
    }
}