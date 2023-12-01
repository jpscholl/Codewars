/*
//  Author: Jonathan Scholl
//  Date: 12/1/2023
//  Project: https://www.codewars.com/kata/55a5bfaa756cfede78000026/train/csharp
*/
Console.WriteLine("Enter a value: ");
string value = Console.ReadLine();
Console.WriteLine(Problem(value));


static string Problem(String a)
{
    double b;
    if (!double.TryParse(a, out b))
    {
        return "Error";
    }
    else
    {
        return (double.Parse(a) * 50 + 6).ToString();
    }
}
