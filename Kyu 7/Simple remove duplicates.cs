using System;
using System.Collections.Generic;

public class Solution
{
    public static int [] solve (int [] arr)
    {
      //..
      List<int> noDupes = new List<int>();

      for (int i = arr.Length - 1; i >= 0; i--)
      {
          if (!noDupes.Contains(arr[i])) noDupes.Add(arr[i]);
      }

      noDupes.Reverse();
      return noDupes.ToArray();
    }
}
