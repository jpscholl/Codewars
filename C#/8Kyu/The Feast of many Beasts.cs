using System;

namespace The_Feast_of_many_Beasts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Feast("chickadee", "chocolate cake"));
        }

        public static bool Feast(string beast, string dish)
        {
            return beast[0] == dish[0] && beast[beast.Length - 1] == dish[dish.Length - 1];
        }
    }
}
