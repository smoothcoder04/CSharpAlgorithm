using System;

namespace BackTracking
{
    public class BitManipulation
    {
        public double number;
        public string resultbit = "";
        double bitSize = 0;
        public BitManipulation(int num)
        {
            this.number = num;
        }

        public string ConvertToBits()
        {
            for(int bit = 3; bit >=0; bit--)
            {
                bitSize = Math.Pow(2, bit);
                if(number >= bitSize)
                {
                    resultbit = resultbit + "1";
                    number = number-bitSize;
                }
                else
                {
                    resultbit = resultbit + "0";
                }
            }
            return resultbit;
        }
    }
}