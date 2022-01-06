/*
//  Author: Jonathan Scholl
//  Date: 1/5/2022
//  Project: https://www.codewars.com/kata/590e03aef55cab099a0002e8
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace Incrementor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] test = { 1, 2, 3, 3};

            int[] aftermethod = Incrementer(test);

            Console.WriteLine();

            for (int x = 0; x < aftermethod.Length; x++)
            {
                Console.WriteLine(aftermethod[x]);
            }

        }

        public static int[] Incrementer(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (++numbers[i] + i) % 10;
            }
            return numbers;
        }
    }
}
