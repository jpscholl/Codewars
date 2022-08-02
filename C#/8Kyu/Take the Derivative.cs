/*
//  Author: Jonathan Scholl
//  Date: 8/2/2022
//  Project: Codewars - https://www.codewars.com/kata/5963c18ecb97be020b0000a2/
//  
*/
using System;

namespace Take_the_Derivative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a coefficient: ");
            double coefficient = Double.Parse(Console.ReadLine());

            Console.Write("Input an exponent: ");
            double exponent = Double.Parse(Console.ReadLine());

            Console.WriteLine($"The derivative is: {Derive(coefficient,exponent)}");
        }

        public static string Derive(double coefficient, double exponent)
        {
            return (coefficient * exponent) + "x^" + (exponent - 1);
        }
    }
}
