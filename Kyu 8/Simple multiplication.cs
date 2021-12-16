using System;

namespace Simple_multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //input and store number
            Console.Write("Input a number: ");
            int userInputNumber = int.Parse(Console.ReadLine());

            //pass number to method for calculation
            Console.WriteLine(Multiply(userInputNumber));
        }
        //method to calculate results
        public static int Multiply(int x)
        {
            // your code........
            int calcResults = 0;

            //if number is even multiply by 8 and return
            if (x % 2 == 0)
            {
                calcResults = x * 8;
            }

            //if number is odd multiply by 9 and return
            if (x % 2 == 1)
            {
                calcResults = x * 9;
            }

            return calcResults;
        }
    }
}
