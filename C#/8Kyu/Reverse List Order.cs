/*
//  Author: Jonathan Scholl
//  Date: 1/14/2022
//  Project: https://www.codewars.com/kata/53da6d8d112bd1a0dc00008b
*/
using System;
using System.Collections.Generic;

namespace Reverse_List_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            foreach (int i in ReverseList(new List<int> { 4, 3, 2, 1 }))
            {
                Console.WriteLine(i);
            }
        }
        public static List<int> ReverseList(List<int> list)
        {
            // Return a new list with its elements in reverse order compared to the input list
            // Do not mutate the original list!

            List<int> reversedList = new List<int>();

            foreach (int item in list)
            {
                reversedList.Add(item);
            }
            reversedList.Reverse();
            return reversedList;
        }
    }
}
