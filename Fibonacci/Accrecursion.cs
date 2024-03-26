namespace fibonacci
{
    class accrecursion
    {

        public int accrecursionmethod(int num, int acc)
        {
            int num0 = 0;
            int num1 = 1;

            if(num == 0 || num == 1)
            {
                acc = num;
                return acc;
            }
            for(int i=2; i<=num; i++)
            {
                acc = num0 + num1;
                num0 = num1;
                num1 = acc;
            }
            return acc;
        }
    }
}