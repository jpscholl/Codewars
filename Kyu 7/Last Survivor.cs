/*
//  Author: Jonathan Scholl
//  Date: 1/7/2022
//  Project: https://www.codewars.com/kata/609eee71109f860006c377d1
*/
using System;

namespace Last_Survivor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LastSurvivor("c", new int[] {}));
        }
        public static string LastSurvivor(string letters, int[] coords)
        {
            while (letters.Length != 1)
            {
                for (int i = 0; i < coords.Length; i++)
                {
                    letters = letters.Remove(coords[i], 1);
                }   
            }
            return letters;
        }
    }
}
