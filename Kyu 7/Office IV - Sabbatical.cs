/*
//  Author: Jonathan Scholl
//  Date: 1/5/2022
//  Project: https://www.codewars.com/kata/57fe50d000d05166720000b1
*/
using System;
using System.Text.RegularExpressions;

namespace The_Office_VI___Sabbatical
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Sabb("l", 12, 9));
        }
        public static string Sabb(string s, int val, int happiness)
        {
            Regex rx = new Regex("[sabticlSABTICL]");

            int stringScore = 0;

            foreach (Match match in rx.Matches(s))
            {
                stringScore++;
            }

            if (stringScore + val + happiness > 22)
            {
                return "Sabbatical! Boom!";
            }
            else
            {
                return "Back to your desk, boy.";
            }              
        }
    }
}
