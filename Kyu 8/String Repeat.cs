namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
      string newString = string.Empty;
      
      for (int x = 0; x < n; x++){
        newString += s;
      } 
      return newString;
    }
  }
}
