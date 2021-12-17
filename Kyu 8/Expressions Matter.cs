using System;

namespace Expressions_Matter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExpressionsMatter(1, 2, 3));
        }

        public static int ExpressionsMatter(int a, int b, int c)
        {
            // Your Code here... Happy Coding!
            int largestValue = a + b + c;

            if (largestValue < a * b * c) largestValue = a * b * c;
            if (largestValue < a + b * c) largestValue = a + b * c;
            if (largestValue < a * b + c) largestValue = a * b + c;
            if (largestValue < a * (b + c)) largestValue = a * (b + c);
            if (largestValue < a + (b * c)) largestValue = a + (b * c);
            if (largestValue < (a * b) + c) largestValue = (a * b) + c;
            if (largestValue < (a + b) * c) largestValue = (a + b) * c;

            return largestValue;
        }
    }
}
