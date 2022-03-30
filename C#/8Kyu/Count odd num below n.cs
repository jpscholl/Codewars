/*
//  Author: Jonathan Scholl
//  Date: 3/30/2022
//  Project: https://www.codewars.com/kata/59342039eb450e39970000a6
//  
*/

Console.Write("Input a number: ");
ulong userNumber = ulong.Parse(Console.ReadLine());
Console.WriteLine(OddCount(userNumber));

static ulong OddCount(ulong n) => n/2;
