/*
//  Author: Jonathan Scholl
//  Date: 2/24/2022
//  Project: https://www.codewars.com/kata/539ee3b6757843632d00026b
*/
using System;
using System.Collections.Generic;

namespace Find_the_capitals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "HeLJKeKKweaAXCVllo";
            
            foreach (var item in Capitals(str))
            {
                Console.WriteLine(item);
            };

        }
        public static int[] Capitals(string word)
        {
            //Write your code here
            List<int> upper = new List<int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]) == true)
                {
                    upper.Add(i);
                }
            }
            return upper.ToArray();
        }
    }
}
