/*
//  Author: Jonathan Scholl
//  Date: 12/21/2021
//  Project: https://www.codewars.com/kata/57ee4a67108d3fd9eb0000e7
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_out_the_geese
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        // If you've got a problem with Canada Gooses, you've got a problem with me. And I suggest you let that one marinate.
        // -- Wayne, Letterkenny
        public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
            string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

            return birds.Except(geese);
        }
    }
}
