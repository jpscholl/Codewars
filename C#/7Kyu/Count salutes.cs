/*
//  Author: Jonathan Scholl
//  Date: 1/17/2022
//  Project: https://www.codewars.com/kata/605ae9e1d2be8a0023b494ed
*/
using System;

namespace Count_salutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSalutes(">>>>>>>>>>>>>>>>>>>>>----<->"));
        }
        public static int CountSalutes(string hallway)
        {
            int saluteCounter = 0;

            //going right counter
            for (int i = 0; i < hallway.Length; i++)
            {
                if (hallway[i] == '>')
                {
                    int tempPosition = i;
                    for (int j = tempPosition; j < hallway.Length; j++)
                    {
                        if (hallway[j] == '<') saluteCounter++;
                    }
                }
            }
            //going left counter
            for (int i = hallway.Length - 1;i >= 0; i--)
            {
                if (hallway[i] == '<')
                {
                    int tempPosition = i;
                    for (int j = tempPosition; j >= 0; j--)
                    {
                        if (hallway[j] == '>') saluteCounter++;
                    }
                }
            }
            return saluteCounter;
        }
    }
}
