/*
//  Author: Jonathan Scholl
//  Date: 1/4/2022
//  Project: https://www.codewars.com/kata/55cbd4ba903825f7970000f5
*/
using System;

namespace Grasshopper___Grade_book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetGrade(70, 70, 100));
        }
        public static char GetGrade(int s1, int s2, int s3)
        {
            //Your code goes here...
            int gradeAverage = (s1 + s2 + s3) / 3;

            if (gradeAverage >= 90) return 'A';
            else if (gradeAverage >= 80) return 'B';
            else if (gradeAverage >= 70) return 'C';
            else if (gradeAverage >= 60) return 'D';
            else return 'F';
        }
    }
}
