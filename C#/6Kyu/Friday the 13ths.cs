/*
//  Author: Jonathan Scholl
//  Date: 3/30/2022
//  Project: https://www.codewars.com/kata/540954232a3259755d000039
//  
*/
using System;

namespace Friday_the_13ths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FridayTheThirteenths(1999, 2002));
        }
        public static string FridayTheThirteenths(int Start, int End = int.MinValue)
        {
            if (End < 0) End = Start;

            // do your magic
            var result = string.Empty;
            var startDate = new DateTime(Start, 01, 13);
            var endDate =  new DateTime(End, 12, 13);

            int yearStart = Start;
            int yearEnd = End;
            if (End < Start)
            {
                yearEnd = Start;
            }          

            for (; yearStart <= yearEnd; yearStart++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    DateTime testDate = new DateTime(yearStart, month, 13);
                    if (testDate < startDate) continue;
                    if (testDate > endDate) break;
                    if (testDate.DayOfWeek == DayOfWeek.Friday)
                    {
                        result += testDate.ToString("MM/dd/yyyy") + " ";
                    }
                }
            }
            return result.TrimEnd();
        }
    }
}
