using System;

public static class Kata
{
  public static int CountSheeps(bool[] sheeps)
  {
    //TODO
    int sheepCount = 0;
    
    foreach (var item in sheeps)
      {
        if (item == true)
        {
          sheepCount++;
        }   
      }
    return sheepCount;
   }
}
