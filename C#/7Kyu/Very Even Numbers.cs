/*
//  Author: Jonathan Scholl
//  Date: 2/22/2022
//  Project: https://www.codewars.com/kata/58c9322bedb4235468000019
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace Very_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input a number and store
            Console.Write("Input an integer: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //pass number to method for results
            Console.WriteLine(IsVeryEvenNumber(userInput));
        }
        public static bool IsVeryEvenNumber(int number)
        {
            int sum = 0;
            //if number is too low, throw exception
            //if number is already single digit, then check number
            if (number < 0) throw new ArgumentException();
            else if (number < 9) return number % 2 == 0;
            //while added digits total greater than 9, then split and add again
            while (number > 9)
            {
                //split digits into List
                List<int> list = splitDigits(number);
                //add together digits
                for (int i = 0; i < list.Count; i++)
                {
                    sum += list[i];
                }
                //resets number for loop
                number = sum;
                //if sum is single digit break loop
                if (sum < 10) break;
                //if loop isn't broken reset sum
                sum = 0;
            }
            //return results
            return sum % 2 == 0;
        }
        public static List<int> splitDigits(int num)
        {
            List<int> digits = new List<int>();

            while (num > 0)
            {
                digits.Add(num % 10);
                num /= 10;
            }
            return digits;
        }
    }
}
