using System;

class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("整数を入力してください");
        // var x = int.Parse(Console.ReadLine());
        // var y = x * x;
        // Console.WriteLine($"{x} × {x} = {y}");
        string s = "abcdef";
        Console.WriteLine(s + "ghi");
        Console.WriteLine(s.Contains("bc"));
        Console.WriteLine(s.Replace("bc", "__"));
    }
}