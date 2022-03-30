/*
//  Author: Jonathan Scholl
//  Date: 3/30/2022
//  Project: https://www.codewars.com/kata/57f781872e3d8ca2a000007e
//  
*/

int[] numArray = new[] { 1, 2, 3 };

foreach(int num in Maps(numArray))
{
    Console.WriteLine(num);
}

static int[] Maps(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = x[i] * 2;
    }
    return x;
}
