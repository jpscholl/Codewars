/*
//  Author: Jonathan Scholl
//  Date: 12/15/2021
//  Project: https://www.codewars.com/kata/5933a1f8552bc2750a0000ed
*/
using System;

namespace Get_the_Nth_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input term: ");
            int userInputTerm = int.Parse(Console.ReadLine());

            Console.WriteLine($"{userInputTerm} => {NthEven(userInputTerm)}");
        }
        public static int NthEven(int n)
        {
            //Your coded
            int lastEven = 0;
            
            for (int x = 0; x < n * 2; x += 2)
            {
                if (x % 2 == 0) lastEven = x;
            }

            return lastEven;
        }
    }
}
