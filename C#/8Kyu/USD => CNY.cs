/*
//  Author: Jonathan Scholl
//  Date: 3/30/2022
//  Project: https://www.codewars.com/kata/5977618080ef220766000022
//  
*/
using System;

namespace USD_to_CNY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input dollars: ");
            int userDollars = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Usdcny(userDollars));
        }

        public static string Usdcny(int usd)
        {
            return (usd * 6.75).ToString("F2") + " Chinese Yuan";
        }
    }
}
