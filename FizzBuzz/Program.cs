using System;
using System.Collections.Generic;


namespace FizzBuzzCode
{
   class Program
   {
     public static void Main(string[] args)
     {
        var mymethod = new FizzBuzz();
        IList<string> myresult = mymethod.FizzBuzzAlgo(5);
        foreach(var item in myresult)
        {
            Console.WriteLine(item);
        }
     }
   }
}
