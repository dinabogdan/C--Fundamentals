using System;

namespace MethodsAndFunctions
{
    class Program
    {
        // Methods with parameters

        static int Sum(int x, int y)
        {
            return x + y;
        }

        // out parameters method definition
        static int Divide(int x, int y, out int remainder)
        {
            remainder = x % y;
            return x / y;
        }

        // default parameters
        static int DivideByNumberOrDefault2(int x, int y = 2)
        {
            return x / y;
        }

        // named parameters
        static void PrintCustomerDetails(string name, string phoneNumber, string address, string firstName,
            string middleName, int age)
        {
            // writing to the console.
        }


        // params - parameter

        static int SumNumbers(params int[] numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            return sum;
        }

        static int GiveMeFive()
        {
            return 5;
        }

        static void Main(string[] args)
        {
            var five = GiveMeFive();
            Console.WriteLine(five);

            var sum = Sum(5, 6);
            Console.WriteLine($"Sum is {sum}");

            // out parameters
            bool tryParse = int.TryParse("s", out var parsedResult);

            Console.WriteLine($"Parsing result is: {tryParse} for parsedResult: {parsedResult}");

            var divisionResult = Divide(10, 3, out var remainder);
            Console.WriteLine($"DivisionResult: {divisionResult} with remainder: {remainder}");

            var result = DivideByNumberOrDefault2(10, 5);
            Console.WriteLine(result);

            PrintCustomerDetails(phoneNumber: "0744444400", name: "John", address: "some address", firstName: "Doe",
                middleName: "No middle name", age: 10);

            Console.WriteLine($"Sum is {SumNumbers(1, 2, 3, 4, 5, 6, 7, 8)}");
        }
    }
}
