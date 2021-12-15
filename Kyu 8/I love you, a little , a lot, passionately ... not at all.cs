/*
//  Author: Jonathan Scholl
//  Date: 12/14/2021
//  Project: https://www.codewars.com/kata/57f24e6a18e9fad8eb000296
*/
using System;

namespace I_love_you_a_little_a_lot
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x < 5555; x++)
            {
                Console.Write($"{x}: ");
                Console.WriteLine(HowMuchILoveYou(x));
            }
        }
        public static string HowMuchILoveYou(int nb_petals)
        {
            // your code
            nb_petals -= 1;

            string[] outputMSG = {"I love you", "a little", "a lot", 
                "passionately", "madly", "not at all"};

            if (nb_petals >= 13)
            {
                return outputMSG[nb_petals % 6];
            }
            if (nb_petals >= 6)
            {
                return outputMSG[nb_petals % 6];
            }
            return outputMSG[nb_petals];
        }
    }
}
