/*
//  Author: Jonathan Scholl
//  Date: 12/17/2021
//  Project: https://www.codewars.com/kata/52adc142b2651f25a8000643/train/csharp
*/
using System;

namespace Sleigh_Authentication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Authenticate("Santa Claus", "Ho Ho Ho!"));
        }
        public static bool Authenticate(string name, string password)
        {
            // TODO
            return name == "Santa Claus" && password == "Ho Ho Ho!";
        }
    }
}
