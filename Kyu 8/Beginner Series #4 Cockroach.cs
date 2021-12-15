/*
//  Author: Jonathan Scholl
//  Date: 12/14/2021
//  Project: https://www.codewars.com/kata/55fab1ffda3e2e44f00000c6/train/csharp
*/
using System;

namespace Cockroach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{CockroachSpeed(1.08)}");
        }
        public static int CockroachSpeed(double x)
        {
            //#Happy Coding! ^_^
            return (int)Math.Floor(x * 27.7778);

        }
    }
}
