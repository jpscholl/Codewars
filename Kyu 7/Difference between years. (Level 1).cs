/*
//  Author: Jonathan Scholl
//  Date: 1/10/2022
//  Project: https://www.codewars.com/kata/search/csharp?q=&r[]=-8&r[]=-7&xids=played&beta=false
*/
using System;

namespace Difference_between_years.__Level_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HowManyYears("1997/10/10", "2015/10/10"));
        }
        public static int HowManyYears(string date1, string date2)
        {
            return Math.Abs(Convert.ToDateTime(date1).Year - Convert.ToDateTime(date2).Year);
        }
    }
}
