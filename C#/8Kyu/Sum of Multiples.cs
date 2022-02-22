/*
//  Author: Jonathan Scholl
//  Date: 2/22/2022
//  Project: https://www.codewars.com/kata/57241e0f440cd279b5000829
*/
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

Console.WriteLine("Input first integer:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second integer:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumMul(n, m));

static int SumMul (int n, int m)
{
    List<int> multList = new List<int>();

    if (n > m || n <= 0 || m <= 0) throw new ArgumentException();

    for (int i = n; i < m; i++)
    {
        if (i % n == 0)
        {
            multList.Add(i);
        }
    }

    return multList.Sum();
}
