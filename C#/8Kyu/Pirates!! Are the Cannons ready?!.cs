/*
//  Author: Jonathan Scholl
//  Date: 1/13/2022
//  Project: https://www.codewars.com/kata/5748a883eb737cab000022a6
*/
using System;
using System.Collections.Generic;

namespace Pirates___Are_the_Cannons_ready.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrrr ye ready to fire ye salty dogs?!\n");

            Dictionary<string, string> gunners = new Dictionary<string, string>
            {
                {"Mike", "aye"},
                {"Joe", "aye"},
                {"Johnson", "aye"},
                {"Peter", "aye"}
            };

            foreach (var item in gunners)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine(CannonsReady(gunners));

        }
        public static string CannonsReady(Dictionary<string, string> gunners)
        {
            if (gunners.ContainsValue("nay")) return "Shiver me timbers!";
            return "Fire!";
        }
    }
}
