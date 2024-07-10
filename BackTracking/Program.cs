using System;

namespace BackTracking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BitManipulation myresult = new BitManipulation(9);
            Console.WriteLine($"The bit equivalent of string is - {myresult.ConvertToBits()}");

            SubsetOfArray mySubsets = new SubsetOfArray();
            int[] arr = {1,2,3};
            mySubsets.funcSubset(arr);
        }
    }
}