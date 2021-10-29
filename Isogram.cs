using System;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    //stores into array
            char[] checkArray = str.ToCharArray();

            //assuming isogram is true if null
            if (str == "") return true;

            //loop to check values and return false if matching value found
            for (int x = 0; x < str.Length - 1; x++)
            {
                //Console.WriteLine($"Current outer: {str[x]}");
                for (int y = x + 1; y < str.Length; y++)
                {
                    //Console.WriteLine($"Compare {str[x]} == {str[y]}");
                    if (char.ToLower(str[x]) == char.ToLower(str[y])) return false;
                }
            }

            //no matching value found then return true
            return true;
  }
}
