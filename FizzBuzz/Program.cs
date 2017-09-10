using System;

namespace FizzBuzz
{
    internal static class Program
    {
        private static void Main()
        {
            for(var i = 1; i <= 100; i++)
                Console.WriteLine(FizzBuzz.FizzBuzzEvaluate(i));
        }
    }
}