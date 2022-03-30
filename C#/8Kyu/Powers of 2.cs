/*
//  Author: Jonathan Scholl
//  Date: 3/30/2022
//  Project: https://www.codewars.com/kata/57a083a57cb1f31db7000028
//  
*/
using System;
using System.Numerics;

Console.WriteLine("Input integer: ");
int userNumber = int.Parse(Console.ReadLine());

foreach (var num in PowersOfTwo(userNumber))
{
    Console.WriteLine(num);
}

static BigInteger[] PowersOfTwo(int n)
{
    BigInteger[] result = new BigInteger[n + 1];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = (BigInteger)Math.Pow(2, i);
    }

    return result;
}
