/*
//  Author: Jonathan Scholl
//  Date: 12/17/2021
//  Project: https://www.codewars.com/kata/5ad0d8356165e63c140014d4
*/
using System;

namespace Students_Final_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FinalGrade(55, 0));
        }
        public static int FinalGrade(int exam, int projects)
        {
            if (exam > 90 || projects > 10) return 100;
            if (exam > 75 && projects >= 5) return 90;
            if (exam > 50 && projects >= 2) return 75;
            return 0;
        }
    }
}
