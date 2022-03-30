/*
//  Author: Jonathan Scholl
//  Date: 3/30/2022
//  Project: https://www.codewars.com/kata/58f8a3a27a5c28d92e000144/train/csharp
//  
*/

int[] numArray = new int[] { 1, 2, 3, 4, 6, 7, 8 };
Console.WriteLine(FirstNonConsecutive(numArray));


static object FirstNonConsecutive(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {

        if (arr[i] - 1 != arr[i - 1]) 
        { 
            return arr[i];
        }
            
    }
    return null;
}
