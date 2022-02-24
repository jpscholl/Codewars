/*
//  Author: Jonathan Scholl
//  Date: 2/24/2022
//  Project: https://www.codewars.com/kata/525d9b1a037b7a9da7000905
*/
using System;
using System.Linq;

namespace Javascript_filter___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] a = { new[] { "foo", "foo@foo.com" }, new[] { "bar_", "bar@bar.com" } };

            string[][] b = search_names(a);

            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    Console.Write(b[i][j]);
                }
                Console.WriteLine();
            }

        }
        public static string[][] search_names(string[][] logins)
        {
            // your code
            return logins.Where(x => x.First().EndsWith("_")).ToArray();
        }

    }
}
