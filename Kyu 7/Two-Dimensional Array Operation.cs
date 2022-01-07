/*
//  Author: Jonathan Scholl
//  Date: 1/7/2022
//  Project: https://www.codewars.com/kata/60bcef3c4a3ef30015bc05dd
*/
using System;
using System.Collections.Generic;

namespace Two_Dimensional_Array_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Result(new int[,] { { 7, 1, 5, 8 }, { 2, 1, 4, 9 }, { 3, 2, 4, 7 } }));
        }
        public static int Result(int[,] array)
        {
            if (array.Length == 1) return array[0,0];

            List<int> multiplyNums = new List<int>();
            int sum = 0, result = 1;
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                } 
                multiplyNums.Add(sum);
            }

            for (int i = 0; i < multiplyNums.Count; i++)
            {
                result *= multiplyNums[i];
            }
            return result;
        }
    }
}
