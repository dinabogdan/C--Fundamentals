using System;
using System.Globalization;

namespace NullableTypesAndExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nullable types

            // Nullable value types
            //int? x = null;
            Nullable<int> x = null;
            int y = 3;

            Console.WriteLine($"Value of x is {x} and type is {typeof(Nullable<int>)} the same as {typeof(int?)}");
            Console.WriteLine($"Value of y is {y} and type is {y.GetType()}");

            // Nullable reference types
            AnimalOwner? person = null;
            AnimalOwner person2 = null;

            Console.WriteLine($"Person name is {person?.Name}");

            var person3 = new AnimalOwner();
            Console.WriteLine($"Person3 Name is {person3.Name}");

            // Null-conditional operator (?.)

            Dog? dog = null;
            AnimalOwner animalOwner = new AnimalOwner { Name = "John Doe", OwningDog = dog };
            AnimalOwner? nullableAnimalOwner = null;

            Console.WriteLine($"{animalOwner.Name} owns dog with name {animalOwner.OwningDog?.Name}");
            Console.WriteLine($"{nullableAnimalOwner?.Name} owns dog with name {nullableAnimalOwner?.OwningDog?.Name}");

            // Null-coalescing operator (??)
            AnimalOwner anotherAnimalOwner = new AnimalOwner
            {
                Name = "Tom",
                OwningDog = dog ?? new Dog { Name = "Spike" }
            };

            Console.WriteLine($"{anotherAnimalOwner.Name} owns dog with name {anotherAnimalOwner.OwningDog.Name}");

            // Null-suppression operator (!)
            string potentialNullableReference = null!;

            // throwing exceptions

            MyException myException = new MyException("Some error");
            // throw keyword
            //throw myException;

            try
            {
                throw myException;
            }
            catch (MyException ex)
            {
                Console.WriteLine($"Handling exception with message {ex.Message}");
            }

            try
            {
                int.Parse("a");
            }
            catch (FormatException fex)
            {
                Console.WriteLine("Format exception " + fex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic catch block");
            }

        }
    }
}
