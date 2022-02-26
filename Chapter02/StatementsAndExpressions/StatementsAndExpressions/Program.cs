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
                Console.WriteLine("x is equal to 3");
            }

            // 4. Switch

            var sport = "Tennis";

            switch (sport)
            {
                case "Football":
                    Console.WriteLine("We are Europeans");
                    Console.WriteLine("Let's watch Uefa Champions League!");
                    Console.WriteLine("Crying on football matches");
                    break;
                case "Soccer":
                    Console.WriteLine("We are Americans");
                    Console.WriteLine("Better watch NFL and American Football");
                    Console.WriteLine("Baseball is a great sport");
                    break;
                default:
                    Console.WriteLine("No football or soccer at all :( ");
                    Console.WriteLine("Hopefully we will play tennis");
                    break;
            }

            // 5. While

            var t = 3;

            while (t < 10)
            {
                Console.WriteLine($"While condition evaluated to true for value of 't': {t}");
                t++;
            }

            // 6. Do-While

            var m = 3;

            do
            {
                m++;
                Console.WriteLine($"Do while condition evaluated to true for value of 'm': {m}");
            } while (m < 10);

            // 7. For 

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Value of 'i': {i}");
            }
        }
    }
}
