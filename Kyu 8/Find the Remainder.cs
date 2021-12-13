/*
//  Author: Jonathan Scholl
//  Date: 12/13/2021
//  Project: Code Wars - Kyu 8 - Kata Find the Remainder
*/
using System;

namespace Find_the_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input num 1: ");
            int userInputNum1 = int.Parse(Console.ReadLine());

            Console.Write("Input num 2: ");
            int userInputNum2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Remainder: {Remainder(userInputNum1, userInputNum2)}");

        }
        public static int Remainder(int a, int b)
        {
            int largeNum = 0, smallNum = 0;

            if (a > b)
            {
                largeNum = a;
                smallNum = b;
            }
            else
            {
                smallNum = a;
                largeNum = b;
            }

            if (smallNum == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return largeNum % smallNum;
            }

        }
    }
}
