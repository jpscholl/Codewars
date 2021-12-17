using System;

namespace Grasshopper___Summation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(summation(8));
        }
        public static int summation(int num)
        {
            //Code here
            int sumOfNum = 0;

            for (int x = 0; x <= num; x++)
            {
                sumOfNum += x;
            }
            return sumOfNum;
        }
    }
}
