public static bool IsPrime(int n)
{
   if (n < 2) return false;
   if (n == 2) return true;

   int maximumDividor = (int)Math.Sqrt(n) + 1;
   for (int i = 2; i < maximumDividor; i++)
   {
        if (n % i == 0) return false;
   }
   return true;
}
