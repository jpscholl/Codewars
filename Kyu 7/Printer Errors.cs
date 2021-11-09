/*
//  Author: Jonathan Scholl
//  Date: 11/9/2021
//  Project: Code Wars - Kyu 7 - Printer Error
//  Description: https://www.codewars.com/kata/56541980fa08ab47a0000040/train/csharp
*/
using System;
using System.Linq;

namespace Printer_Errors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing PrinterError");
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";

            Console.WriteLine(PrinterError(s));
        }
        //one line System.Linq solution
        public static string PrinterError(String s) => s.Where(x => x > 'm').Count() + "/" + s.Length;
        /*
    {
        //my solution
        // your code
        int errorCount = 0;

        for (int x = 0; x < s.Length; x++)
        {
            if (s[x] > 'm') errorCount++;
        }

        return $"{errorCount}/{s.Length}";
        
    }
        */
    }
}
