namespace Matrix
{
    public class Solution
    {
        public void IsIsland(char[][] grid, int i, int j, int[,] M)
        {
            if (M[i, j] == 1)
            {
                return;
            }
            //current node visited
            M[i, j] = 1;
            if (grid[i][j] == '0')
            {
                return;
            }

            //column: check if the end element
            if (j + 1 < grid[0].Length)
            {
                //right
                IsIsland(grid, i, j + 1, M);

            }
            //column: check if 1st element
            if (j - 1 >= 0)
            {
                //left
                IsIsland(grid, i, j - 1, M);
            }
            //rows: check if the end element
            if (i + 1 < grid.Length)
            {
                //below
                IsIsland(grid, i + 1, j, M);

            }
            //rows: check if the 1st element
            if (i - 1 >= 0)
            {
                //top
                IsIsland(grid, i - 1, j, M);
            }


        }
        public int NumIslands(char[][] grid)
        {
            int[,] M = new int[grid.Length, grid[0].Length];
            Console.WriteLine(M[0, 0]);
            int gridrow = grid.Length;
            int gridcolumn = grid[0].Length;
            int islandCount = 0;

            for (int i = 0; i < gridrow; i++)
            {
                for (int j = 0; j < gridcolumn; j++)
                {
                    if (M[i, j] == 1)
                    {
                        continue;
                    }
                    //current node visited
                    //M[i,j] =1;

                    //island 
                    if (grid[i][j] == '1')
                    {
                        //M[i, j] = 0;
                        islandCount++;
                        IsIsland(grid, i, j, M);

                    }
                }
            }
            return islandCount;
        }
    }
}

