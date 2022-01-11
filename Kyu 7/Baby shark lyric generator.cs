/*
//  Author: Jonathan Scholl
//  Date: 1/10/2022
//  Project: 
*/
using System;

namespace Baby_shark_lyrics_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BabySharkLyrics());
        }
        public static string BabySharkLyrics()
        {
            var s = "";
            foreach (var v in "Baby_,Mommy_,Daddy_,Grandma_,Grandpa_,Let's go hunt".Split(',')) { s += ("lll" + v + "!\n").Replace("l", v + ",......\n").Replace("_", " shark").Replace(".", " doo"); }
            return s + "Run away,…\n";
        }
    }
}
