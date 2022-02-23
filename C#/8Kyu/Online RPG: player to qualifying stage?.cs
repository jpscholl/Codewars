/*
//  Author: Jonathan Scholl
//  Date: 2/23/2022
//  Project: https://www.codewars.com/kata/55849d76acd73f6cc4000087
*/
using System;

namespace Online_RPG_player_to_qualifying_stage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PlayerRankUp(100));
            Console.WriteLine(PlayerRankUp(69));
        }
        public static Object PlayerRankUp(int points)
        {
            string qualified = "Well done! You have advanced to the qualifying stage. " +
                "Win 2 out of your next 3 games to rank up.";

            if (points > 99) return qualified;
            else return false;
        }
    }
}
