public class Kata
{
  public static int FindLongest(int[] number)
  {
    // code here
    int mostDigits = number[0];

    for (int x = 1; x < number.Length; x++)
    {
       if (number[x].ToString().Length > mostDigits.ToString().Length) mostDigits = number[x];
    }

    return mostDigits;
    
  }
}
