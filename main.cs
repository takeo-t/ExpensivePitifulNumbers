using System;
using MyNamespace;
using overLoad;
using MyNamespace2;

class Program
{
    public static void Main(string[] args)
    {
        // 配列を作成してからメソッドに渡す
        int[] numbers = { 10, 20 };

        Utilities.Calculate(numbers);
        OverClass.WriteTypeAndValue("Hello");
        OverClass.WriteTypeAndValue(10);
        OverClass.WriteTypeAndValue(3.14);
        Complex z = new Complex();
        z.Re = 3;
        z.Im = 4;

        double abs = z.Abs();
        Console.WriteLine($"abs = {abs}")
    }
}
