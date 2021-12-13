/*
//  Author: Jonathan Scholl
//  Date: 12/13/2021
//  Project: Code Wars - 8 Kyu - DNA to RNA Conversion
//  Description: Create a function which translates a given DNA string into RNA
*/
using System;

namespace DNA_to_RNA_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string DNA = "GCAT";

            Console.WriteLine($"{DNA} => {dnaToRna(DNA)}");

        }
        public static string dnaToRna(string dna)
        {
            // Have fun! ^_^
            return dna.Replace("T", "U");
        }
    }
}
