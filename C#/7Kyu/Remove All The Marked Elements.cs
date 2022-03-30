using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_All_The_Marked_Elements_of_a_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integerList = new int[] { 1, 1, 2, 3, 1, 2, 3, 4 };
            int[] valuesList = new int[] { 1, 3 };

            int[] removedArray = Remove(integerList, valuesList);
            foreach (int value in removedArray)
            {
                Console.WriteLine(value);
            }
        }
        public static int[] Remove(int[] integerList, int[] valuesList)
        {
            // your code here
            List<int> removed = new List<int>();

            foreach (int value in integerList)
            {
                if (!valuesList.Contains(value))
                {
                    removed.Add(value);
                }
            } 
            return removed.ToArray();
        }
    }
}
