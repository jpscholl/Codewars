/*
//  Author: Jonathan Scholl
//  Date: 12/14/2021
//  Project: https://www.codewars.com/kata/56170e844da7c6f647000063
*/
using System;

namespace Drink_about
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input age: ");
            int userInputAge = int.Parse(Console.ReadLine());

            Console.WriteLine($"{userInputAge} => {PeopleWithAgeDrink(userInputAge)}");
        }
        public static string PeopleWithAgeDrink(int old)
        {
            if (old >= 21) return "drink whisky";
                else if (old >= 18) return "drink beer";
                    else if (old >= 14) return "drink coke";
                        else return "drink toddy";
        }
    }
}
