public static int SquareSum(int[] n)
        {
            int sum = 0;

            for (int x = 0; x < n.Length; x++)
            {
                sum += n[x] * n[x];
            }

            return sum;
        }
