using System;

public static class Kata
{
  public static int MakeNegative(int number)
  {
    // Code?
    if (number == 0) 
    {
      return 0;
    }
    else if (number < 0) 
    {
      return number;
      }
    else 
      {
        return number - (number * 2);
      }  
  }
}
