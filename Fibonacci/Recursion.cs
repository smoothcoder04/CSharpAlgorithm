namespace fibonacci
{
    class recursion
    {

        public int recursionfibo(int number)
        {
            //base case - stop condition
            if(number == 0 || number == 1)
            {
                return number;
            }
            //recursive case
            return recursionfibo(number-1) + recursionfibo(number-2);
        }
    }
}