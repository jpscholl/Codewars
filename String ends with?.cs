public class Kata
{
  public static bool Solution(string str, string ending)
  {
    // TODO: complete
    if (str == ending) return true;
    if (str.Length > ending.Length) return str.Substring(str.Length - ending.Length, ending.Length) == ending;
    else return false;
  }
}

//another solution
//return str.EndsWith(ending);
