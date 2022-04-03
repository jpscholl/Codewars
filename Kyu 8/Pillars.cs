using System;

namespace Pillars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pillars(1,20,25));
        }
        public static int Pillars(int numPill, int dist, int width)
        {
            if (numPill <= 1)
            {
                return 0;
            }
            else
            {
                return dist * (numPill - 1) * 100 + (width * (numPill - 2)); 
            }                
        }
    }
}
