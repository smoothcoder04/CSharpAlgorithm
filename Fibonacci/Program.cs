using System;

namespace fibonacci
{
    class Program
    {
        public static void Main()
        {
            var myfibo = new recursion();
            var result = myfibo.recursionfibo(5);
            Console.WriteLine($"Fibonacci of the number is {result}");

            //with acc
            var myfiboacc = new accrecursion();
            var accresult = myfiboacc.accrecursionmethod(5, 0);
            Console.WriteLine($"Fibonacci of the number is {accresult}");
        }
    }
}