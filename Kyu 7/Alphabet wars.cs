/*
//  Author: Jonathan Scholl
//  Date: 11/2/2021
//  Project: Code Wars - Alphabet wars
//  Description: 
*/
using System;
using System.Linq;

namespace Alphabet_War
{
    class Program
    {
        static void Main(string[] args)
        {
            string fightString = "zdqmwpbs";

            Console.WriteLine("Winner: " + AlphabetWar(fightString));
        }
        public static string AlphabetWar(string fight)
        {
            char[] leftSideLetters = {'s', 'b', 'p', 'w' };
            char[] rightSideLetters = {'z', 'd', 'q', 'm'};

            int leftCount = 0;
            int rightCount = 0;
            
            for (int x = 0; x < fight.Length; x++)
            {
                for(int y = 0; y < 4; y++)
                {
                    if (fight[x] == leftSideLetters[y]) leftCount += y + 1;
                    if (fight[x] == rightSideLetters[y]) rightCount += y + 1;
                }     
            }

            Console.WriteLine($"{leftCount} == {rightCount}");

            return leftCount == rightCount ? "Let's fight again!" :
                leftCount > rightCount ? "Left side wins!" : "Right side wins!";
        }
    }
}
