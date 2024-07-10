using System;

namespace BackTracking
{
    public class SubsetOfArray
    {
        public void funcSubset(int[] arr)
        {
            int n = arr.Length; //3
            for (int i = 0; i < (1 << n); i++) // [1,2,3] = [1 => 001] => [001, 010, 100] //  0>=i<= (1<<n) 1= 0001, 2n = 8 i =2
            {
                for (int j = 0; j < n; j++) // [001, 010, 100] 
                {
                    if ((i & (1 << j)) != 0) // [001] = [010] i=6, 0110 & 0100 != 0 =0100
                    {
                        Console.WriteLine(arr[j] + " "); //[1], 
                                                         //   [2] 
                                                         // 2, 3
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

