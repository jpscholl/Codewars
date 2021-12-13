/*
//  Author: Jonathan Scholl
//  Date: 12/13/2021
//  Project: Code Wars - 8 kyu - Basic variable assignment
//  Description: This code should store "codewa.rs" as a variable called name 
//  but it's not working. Can you figure out why?
*/
using System;

namespace Basic_variable_assignment
{
    class Program
    {
        public static string A = "code";
        public static string B = "wa.rs";
        public static string Name = A + B;
        static void Main(string[] args)
        {
            Console.WriteLine($"{A} + {B} = {Name}");
        }
    }
}
