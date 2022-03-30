*
//  Author: Jonathan Scholl
//  Date: 3/30/2022
//  Project: https://www.codewars.com/kata/5590961e6620c0825000008f
//  
*/
using System;

namespace Case_Swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input string: ");
            string userInput = Console.ReadLine();
            Console.WriteLine(Swap(userInput));
        }
        public static string Swap(string str)
        {
            if (str == String.Empty) return str;

            char[] splitString = str.ToCharArray();
            str = String.Empty;

            for (int i = 0; i < splitString.Length; i++)
            {
                if (char.IsUpper(splitString[i]))
                {
                    str += char.ToLower(splitString[i]);
                }
                else
                {
                    str += char.ToUpper(splitString[i]);
                }
            }
            
            return str;
        }
    }
}
