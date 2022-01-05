/*
//  Author: Jonathan Scholl
//  Date: 1/4/2022
//  Project: https://www.codewars.com/kata/58649884a1659ed6cb000072
*/
using System;

namespace Thinkful___Logic_Drills___Traffic_Light
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UpdateLight("green"));
            Console.WriteLine(UpdateLight("yellow"));
            Console.WriteLine(UpdateLight("red"));

        }
        public static string UpdateLight(string current)
        {
            //Do Some Magic
            if (current == "green") return "yellow";
            if (current == "yellow") return "red";
            return "green";
        }
    }
}
