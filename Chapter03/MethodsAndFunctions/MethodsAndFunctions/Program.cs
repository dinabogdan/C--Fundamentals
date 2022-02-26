using System;
using System.Diagnostics.CodeAnalysis;

namespace MethodsAndFunctions
{
    class Program
    {
        int Sum(int x, int y)
        {
            return x + y;
        }

        static int GiveMeFive()
        {
            return 5;
        }

        static void Main(string[] args)
        {
            var five = GiveMeFive();

            Console.WriteLine(five);
        }
    }
}
