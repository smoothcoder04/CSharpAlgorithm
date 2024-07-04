using System;

namespace BackTracking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BitManipulation myresult = new BitManipulation(9);
            Console.WriteLine($"The bit equivalent of string is - {myresult.ConvertToBits()}");
        }
    }
}