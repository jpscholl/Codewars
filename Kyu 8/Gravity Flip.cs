/*
//  Author: Jonathan Scholl
//  Date: 1/17/2022
//  Project: https://www.codewars.com/kata/5f70c883e10f9e0001c89673
*/
using System;

namespace Gravity_Flip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = Flip('L', new int[] { 1, 4, 5, 3, 5 });
            foreach(int i in test)
            {
                Console.WriteLine(i); 
            }
        }
        public static int[] Flip(char dir, int[] arr)
        {
            Array.Sort(arr);
            if (dir == 'R')
            {
                return arr; 
            }
            else
            {
                Array.Reverse(arr);
                return arr;
            } 
        }
    }
}
