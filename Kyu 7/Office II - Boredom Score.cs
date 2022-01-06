/*
//  Author: Jonathan Scholl
//  Date: 1/5/2022
//  Project: https://www.codewars.com/kata/57ed4cef7b45ef8774000014 
*/
using System;
using System.Collections.Generic;

namespace The_Office_II___Boredom_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> staff = new Dictionary<string, string>() 
            { 
            { "Tim", "accounts" }, { "Jim", "trading" }, { "Sandy", "regulation" }, 
                { "Andy", "accounts" }, { "Katie", "finance" }, { "Laura", "IS" }
            };

            Console.WriteLine(Boredom(staff));

        }
        public static string Boredom(Dictionary<string, string> staff)
        {
            int boredomScore = 0;

            Dictionary<string, int> boredomValue = new Dictionary<string, int>()
            {
                { "accounts", 1 }, { "finance", 2 }, { "canteen", 10 }, { "regulation", 3}, { "trading", 6 },
                { "change", 6 }, { "IS", 8 }, { "retail", 5 }, { "cleaning", 4}, {"pissing about", 25 }
            };

            foreach (KeyValuePair<string, string> kvp in staff)
            {
                string current = kvp.Value;
                if (boredomValue.ContainsKey(current)) boredomScore += boredomValue[current];
            }

            if (boredomScore > 100) return "party time!!";
            else if (boredomScore <= 100 && boredomScore > 80) return "i can handle this";
            return "kill me now";
            
        }
    }
}
