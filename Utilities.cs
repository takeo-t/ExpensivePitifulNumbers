using System;

namespace MyNamespace {
    public static class Utilities
    {
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
}