/*
//  Author: Jonathan Scholl
//  Date: 2/24/2022
//  Project: https://www.codewars.com/kata/545cff101288c1d2da0006fb
*/
using System;

namespace Showing_X_to_Y_of_Z_Products_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(PaginationText(3,10,26));
        }
        public static string PaginationText(int pageNumber, int pageSize, int totalProducts)
        {
            var start = 1 + (pageNumber - 1) * pageSize;
            var end = Math.Min(totalProducts, pageSize * pageNumber);
            return $"Showing {start} to {end} of {totalProducts} Products.";
        }
    }
}
