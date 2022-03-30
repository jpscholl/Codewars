/*
//  Author: Jonathan Scholl
//  Date: 3/30/2022
//  Project: 
//  https://www.codewars.com/kata/58aa68605aab54a26c0001a6/solutions
*/
using System;
using System.Linq;

namespace Distinct_Digit_Year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myjinxin.Kata kata = new myjinxin.Kata();
            Console.WriteLine(kata.DistinctDigitYear(1987));
        }
    }
namespace myjinxin
    {
        using System.Linq;
        public class Kata
        {
            public int DistinctDigitYear(int year)
            {
                year++;
                while (year.ToString().Distinct().Count() != 4)
                {
                    year++;
                }
                return year;
            }
        }
    } 
}
