/*
//  Author: Jonathan Scholl
//  Date: 1/4/2022
//  Project: https://www.codewars.com/kata/5672a98bdbdd995fad00000f
*/
using System;

namespace Rock_Paper_Scissors_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rps("rock", "scissor"));
        }

        public static string Rps(string p1, string p2)
        {
            if (p1 == p2) return "Draw!";
            if (p1 == "rock" && p2 == "scissors") return "Player 1 won!";
            if (p1 == "paper" && p2 == "rock") return "Player 1 won!";
            if (p1 == "scissors" && p2 == "paper") return "Player 1 won!";
            if (p1 == "scissors" && p2 == "rock") return "Player 2 won!";
            if (p1 == "rock" && p2 == "paper") return "Player 2 won!";
            return "Player 2 won!";
        }
    }
}
