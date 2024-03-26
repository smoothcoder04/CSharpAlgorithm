namespace FizzBuzzCode
{
    public class FizzBuzz
    {
         public IList<string> FizzBuzzAlgo(int num)
         {
            var myList = new List<string>(num);

            for (int mynum = 1; mynum <= num; mynum++)
                {
                    string result = "";

                    if (mynum % 3 == 0)
                    {
                        result += "Fizz";
                    }

                    if (mynum % 5 == 0)
                    {
                        result += "Buzz";
                    }

                    if (result == "")
                    {
                        result = mynum.ToString();
                    }

                    myList.Add(result);
                }

            return myList;
        
         }   
    }
}
