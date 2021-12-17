using System;
using System.Collections.Generic;

namespace JavaSctipt_Array_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var testArray = new int[] { 1, 2, 3, 4, 5, 6 };

            foreach (var item in testArray)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n");

            foreach (var item in GetEvenNumbers(testArray))
            {
                Console.Write($"{item} ");
            }

        }
        public static int[] GetEvenNumbers(int[] numbers)
        {
            // filter out the odd numbers
            List<int> evenList = new List<int>();

            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % 2 == 0)
                {
                    evenList.Add(numbers[x]);
                }
            }

            return evenList.ToArray();
        }
    }
}
