using System;

namespace Chapter04
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create instance by Constructor
            Person person = new Person("John Doe", 30, "Los Angeles", "+40744440000");

            // Object initializer
            Person someOtherPerson = new Person
            {
                Address = "Los Angeles",
                Age = 30,
                Name = "John Doe",
                PhoneNo = "+40744440000",
                MiddleName = "Middle"
            };

            TShirtSize aTShirtSize = TShirtSize.Small;
            TShirtSize mediumTShirtSize = TShirtSize.Medium;

            Console.WriteLine(aTShirtSize.ToString());
            Console.WriteLine((int)aTShirtSize);
            
            Console.WriteLine(mediumTShirtSize.ToString());
            Console.WriteLine((int)mediumTShirtSize);


        }
    }
}
