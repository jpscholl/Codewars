  using System;
  public static class Clock
  {
    public static int Past(int h, int m, int s)
    {
      //#Happy Coding! ^_^
      TimeSpan interval = new TimeSpan(h, m, s);

      return Convert.ToInt32(interval.TotalMilliseconds);
    }
  }
