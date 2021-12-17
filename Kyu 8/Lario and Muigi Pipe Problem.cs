/*
//  Author: Jonathan Scholl
//  Date: 12/17/2021
//  Project: https://www.codewars.com/kata/56b29582461215098d00000f
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lario_and_Muigi_Pipe_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 3, 5, 6, 7, 8 };
            List<int> fixedPipe = new List<int>();
            fixedPipe.AddRange(nums);

            foreach(var item in fixedPipe)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            PipeFix(fixedPipe);

            foreach (var item in fixedPipe)
            {
                Console.Write($"{item} ");
            }

        }
        public static List<int> PipeFix(List<int> numbers)
        {
            //Good luck!

            for (int x = numbers.Min(); x < numbers.Max(); x++)
            {
                if (!numbers.Contains(x))
                {
                    numbers.Add(x);
                }
            }

            numbers.Sort();

            return numbers;
        }
    }
}
