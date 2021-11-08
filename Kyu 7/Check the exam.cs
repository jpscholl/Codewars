/*
//  Author: Jonathan Scholl
//  Date: 11/8/2021
//  Project: Code Wars - 7th Kyu - Check the Exam
//  Description: The first input array is the key to the correct answers to an exam, like ["a", "a", "b", "d"]. 
//  The second one contains a student's submitted answers.
//
//  The two arrays are not empty and are the same length. Return the score for this array of answers, giving +4 
//  for each correct answer, -1 for each incorrect answer, and +0 for each blank answer, represented as an empty string (in C the space character is used).
//
//  If the score < 0, return 0.
*/
using System;
using System.Linq;

namespace Check_the_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] answerSheet = new string[] {"a", "b", "c", "d" };
            string[] studentAnswersSheet = new string[] { "e", "e", "e", "e" };

            Console.WriteLine($"Score: {CheckExam(answerSheet, studentAnswersSheet)}");

        }
        public static int CheckExam(string[] arr1, string[] arr2)
        {
            int totalScore = 0;

            for (int x = 0; x < arr1.Length; x++)
            {
                if (arr1[x] == arr2[x]) totalScore += 4;
                if (arr2[x] == "") totalScore += 0;
                else if (arr1[x] != arr2[x]) totalScore -= 1;
            }

            return totalScore > 0 ? totalScore : 0;

            //Smart person one liner code
            //return Math.Max(arr2.Select((s, i) => s == "" ? 0 : s == arr1[i] ? 4 : -1).Sum(), 0);
        }
    }
}
