/*
//  Author: Jonathan Scholl
//  Date: 12/14/2021
//  Project: https://www.codewars.com/kata/5808dcb8f0ed42ae34000031
*/
using System;

namespace Switch_it_Up_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int userInputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{SwitchItUp(userInputNumber)}");
        }
        public static string SwitchItUp(int number)
        {
            switch (number)
            {
                case 0: return "Zero"; 
                case 1: return "One"; 
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight"; 
                case 9: return "Nine";
                default: return "Invalid";
            }  
        }
    }
}
