using System;

class Program
{
    public static void Main(string[] args)
    {
        // 配列を作成してからメソッドに渡す
        int[] numbers = { 10, 20 };
        Calculate(numbers);
    }

    // メソッドのパラメータに型を指定
    public static void Calculate(int[] numbers)
    {
        var x = numbers[0];
        var y = numbers[1];
        Console.WriteLine($"In {nameof(Calculate)} method:");
        Console.WriteLine($"{nameof(x)} = {x}");
        Console.WriteLine($"{nameof(y)} = {y}");
        Console.WriteLine($"{nameof(x)} + {nameof(y)} = {x + y}");
    }
}
