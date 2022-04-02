using System;

namespace Chapter04
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create instance by Constructor
            Person person = new Person("John Doe", 30, "Los Angeles", "+40744440000");

            var (name, age, address, phoneNo, middleName) = person;

            // Object initializer
            Person someOtherPerson = new Person
            {
                Address = "Los Angeles",
                Age = 30,
                Name = "John Doe",
                PhoneNo = "+40744440000",
                MiddleName = "Middle"
            };

            // use static field
            Console.WriteLine(Person.Citizenship);
            // use static method
            Person.PrintCitizenship();

            TShirtSize aTShirtSize = TShirtSize.Small;
            TShirtSize mediumTShirtSize = TShirtSize.Medium;

            Console.WriteLine(aTShirtSize.ToString());
            Console.WriteLine((int)aTShirtSize);

            Console.WriteLine(mediumTShirtSize.ToString());
            Console.WriteLine((int)mediumTShirtSize);

            // structs
            var extraSmallSize = new TShirtSizeStruct("ExtraSmall", 10);
            var smallSize = new TShirtSizeStruct("Small", 20);

            Console.WriteLine(extraSmallSize);
            Console.WriteLine(smallSize);

            // reference types vs value types

            var counterRef = new CounterRef();
            var counterStruct = new CounterStruct();

            var counterRef2 = counterRef;
            var counterStruct2 = counterStruct;

            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine($"Iteration {i} - CounterRef next value: {counterRef.GetNextValue()}");
                Console.WriteLine($"Iteration {i} - CounterRef2 next value: {counterRef2.GetNextValue()}");
            }

            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine($"Iteration {i} - CounterStruct next value: {counterStruct.GetNextValue()}");
                Console.WriteLine($"Iteration {i} - CounterStruct2 next value: {counterStruct2.GetNextValue()}");
            }

            // Anonymous types
            var car = new { Manufacturer = "BMW", Year = 2021, Color = "Blue" };
            var anonymousPerson = new { Name = "John Doe", Age = 30, Residency = "US", Sex = "M" };

            Console.WriteLine($"Driving a {car.Color}ed {car.Manufacturer} from {car.Year}");
        }
    }
}
