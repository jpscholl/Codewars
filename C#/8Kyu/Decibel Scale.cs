/*
//  Author: Jonathan Scholl
//  Date: 3/28/2022
//  Project: https://www.codewars.com/kata/5612a42e746aa62de100001a
//  
*/

Console.Write("Input intesity: ");
double intensity = Double.Parse(Console.ReadLine());
Console.WriteLine(DbScale(intensity));

static double DbScale(double intensity)
{
    return 10 * Math.Log10(intensity / Math.Pow(10, -12));
}  
