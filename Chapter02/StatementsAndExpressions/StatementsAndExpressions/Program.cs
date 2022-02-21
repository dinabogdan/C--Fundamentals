using System;

namespace StatementsAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20, b = 10;

            // "+"
            var sum = a + b;

            // "-"
            var diff = a - b;

            // "*"
            var multiply = a * b;

            // "/"
            var div = a / b;

            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Multiply is {multiply}");
            Console.WriteLine($"Diff is {diff}");
            Console.WriteLine($"Div is {div}");

            int x = 3, y = 5, z = 6;

            // "=="
            Console.WriteLine(x == y);
            Console.WriteLine(x == z);

            //// Control flows

            // 1. If-structure

            if (x % 2 == 0)
            {
                Console.WriteLine("x is an even number");
            }

            // 2. If-Else structure

            if (x % 2 == 0)
            {
                Console.WriteLine("x is an even number");
            }
            else
            {
                Console.WriteLine("x is an odd number");
            }

            // 3. If-Else/If-Else/.../Else structure

            if (x > 3)
            {
                Console.WriteLine("x is bigger than 3");
            }
            else if (x < 3)
            {
                Console.WriteLine("x is lower than 3");
            }
            else
            {
                Console.Write("x is equal to 3");
            }
        }
    }
}
