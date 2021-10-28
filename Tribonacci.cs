if (signature.Length > 4)
            {
                double[] newArray = new double[3];
                signature.CopyTo(newArray, 0);
                return newArray;
            }

            double[] tribonacciArray = new double[n];   

            for (int x = 0; x < signature.Length; x++)
            {
                tribonacciArray[x] = signature[x];
            }

            

            for (int y = 3; y < n; y++)
            {
                double newValue = tribonacciArray[y - 1] + tribonacciArray[y - 2] + tribonacciArray[y - 3];
                tribonacciArray[y] = newValue;
            }

            return tribonacciArray;
