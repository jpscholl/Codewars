/*
//  Author: Jonathan Scholl
//  Date: 3/30/2022
//  Project: https://www.codewars.com/kata/56e3cd1d93c3d940e50006a4
//  
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace How_Green_is_my_Valley
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = {79, 35, 54, 19, 35, 25};

            int[] valley = MakeValley(a);

            foreach (int i in valley)
            {
                Console.WriteLine(i);
            }
        }
        //public static int[] MakeValley(int[] arr)
        //{
        //    // your code
        //    Array.Sort(arr);
        //    List<int> leftWing = new List<int>();
        //    List<int> rightWing = new List<int>();
        //    List<int> valley = new List<int>();

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (i % 2 == 0) leftWing.Add(arr[i]);
        //        else rightWing.Add(arr[i]);
        //    }
        //    leftWing.Reverse();

        //    for (int i = 0; i <= leftWing.Count; i++)
        //    {
        //        valley.Add(leftWing[i]);
        //        valley.Add(rightWing[i]);
        //    }

        //    return valley.ToArray();
        //}
        public static int[] MakeValley(int[] arr)
        {
            var leftList = new List<int>();
            var rightList = new List<int>();
            var inputList = arr.ToList();
            inputList.Sort();
            var counter = inputList.Count - 1;
            while (counter >= 0)
            {
                leftList.Add(inputList[counter]);
                counter--;
                if (counter >= 0)
                {
                    rightList.Add(inputList[counter]);
                }
                counter--;
            }
            rightList.Reverse();
            leftList.AddRange(rightList);
            return leftList.ToArray();
        }
    }
}
