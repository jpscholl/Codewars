/*
//  Author: Jonathan Scholl
//  Date: 11/16/2021
//  Project: Code Wars - Kyu 7 - Remove anchor from URL
//  Description: 
*/
using System;

namespace Remove_Anchor_from_URL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveUrlAnchor("HelloWorld!.com#about"));
        }

        public static string RemoveUrlAnchor(string url)
        {
            // TODO: complete
            for (int i = 0; i <= url.Length - 1; i++)
            {
                if (url[i] == '#')
                {
                    return url.Substring(0, i);
                }
            }
            return url;
        }
    }
}
