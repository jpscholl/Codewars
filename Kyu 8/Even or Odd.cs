/*
//  Author: Jonathan Scholl
//  Date: 12/13/2021
//  Project: Code Wars - 8 Kyu - Even or Odd
//  Description: Create a function that takes an integer as an argument and 
//  returns "Even" for even numbers or "Odd" for odd numbers.
*/
using System;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number: ");
            int userInputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(EvenOrOdd(userInputNumber));

        }
        public static string EvenOrOdd(int number)
        {
            // Code goes here ...
            if (number % 2 == 0) return "Even";
            else return "Odd";
        }
    }
}
