using System;
using MyNamespace;
using overLoad;

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
    }
}
