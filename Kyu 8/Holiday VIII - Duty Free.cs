/*
//  Author: Jonathan Scholl
//  Date: 1/4/2022
//  Project: https://www.codewars.com/kata/57e92e91b63b6cbac20001e5
*/
using System;
using System.Linq;

namespace Holiday_VIII___Duty_Free
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DutyFree(17, 10, 500));
  
        }
        public static int DutyFree(int normPrice, int Discount, int hol)
        {
            double discountPrice = normPrice * (double)Discount / 100;
            double totalBottles = hol / discountPrice;

            return (int)totalBottles;
        }
    }
}
