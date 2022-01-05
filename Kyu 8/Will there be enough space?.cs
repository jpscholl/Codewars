/*
//  Author: Jonathan Scholl
//  Date: 1/4/2022
//  Project: https://www.codewars.com/kata/5875b200d520904a04000003/
*/
using System;

namespace Will_there_be_enough_space
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Enough(100,60,50));
        }
        public static int Enough(int cap, int on, int wait)
        {
            if (cap >= on + wait) return 0;
            else return Math.Abs(cap - on - wait);
        }
    }
}
