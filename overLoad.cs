using System;

namespace overLoad 
{
    public static class OverClass
  {
    public static void WriteTypeAndValue(string s)
    {
      Console.WriteLine($"文字列　：　{s}");
    }
    public static void WriteTypeAndValue(int n)
    {
      Console.WriteLine($"整数　：　{n}");
    }
    public static void WriteTypeAndValue(double x)
    {
      Console.WriteLine($"実数　：　{x}");
    }
  }
}