/*
//  Author: Jonathan Scholl
//  Date: 1/17/2022
//  Project: https://www.codewars.com/kata/5bb904724c47249b10000131
*/
using System;

namespace Total_amount_of_points
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] test = new[] { "1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4" };

            Console.WriteLine(TotalPoints(test));
        }
        public static int TotalPoints(string[] games)
        {
            // insert magic here
            int totalPoints = 0;
            for (int i = 0; i < games.Length; i++)
            {
                int teamX = int.Parse(games[i].Substring(0, 1));
                int teamY = int.Parse(games[i].Substring(2, 1));
                totalPoints += teamX > teamY ? 3 : teamX == teamY ? 1 : 0;
            }
            return totalPoints;
        }
    }
}
