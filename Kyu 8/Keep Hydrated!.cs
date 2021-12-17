/*
//  Author: Jonathan Scholl
//  Date: 12/17/2021
//  Project: https://www.codewars.com/kata/582cb0224e56e068d800003c
*/
using System;

namespace Keep_Hydrated_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Litres(3));
        }

        public static int Litres(double time)
        {
            //The fun begins here.
            int litersNeeded = (int)(time * .5);
            return litersNeeded;
        }
    }
}
