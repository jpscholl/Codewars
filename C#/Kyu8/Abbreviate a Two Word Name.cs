/*
//  Author: Jonathan Scholl
//  Date: 12/13/2021
//  Project: Code Wars - Kyu 8 - Abbreviate a Two Word Name
//  Description: Write a function to convert a name into initials. This kata strictly 
//  takes two words with one space in between them.
*/
using System;

namespace Abbreviate_a_Two_Word_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a first and last name: ");
            string fullName = Console.ReadLine();
            Console.WriteLine(AbbrevName(fullName));
        }
        public static string AbbrevName(string name)
        {
            string[] splitName = name.Split(" ");
            string firstInitial = splitName[0].Substring(0, 1);
            string secondInitial = splitName[1].Substring(0, 1);

            return firstInitial.ToUpper() + "." + secondInitial.ToUpper();
        }
    } 
}
