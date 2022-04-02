using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Chapter04
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string MiddleName { get; set; }

        // static field
        public static string Citizenship = "American";
        // readonly field
        public readonly string Country;
        // const field
        public const string Continent = "North America";

        public Person()
        {
            Country = "USA";
        }

        public Person(string name, int age, string address, string phoneNo)
        {
            Name = name;
            Age = age;
            Address = address;
            PhoneNo = phoneNo;
            Country = "USA";
        }

        public void Deconstruct(out string name,
            out int age,
            out string address,
            out string phoneNo,
            out string middleName)
        {
            name = Name;
            age = Age;
            address = Address;
            phoneNo = PhoneNo;
            middleName = MiddleName;
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping at his/her home located at {Address}");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{Name} is eating {food} at his/her home located at {Address}");
        }

        public static void PrintCitizenship()
        {
            Console.WriteLine($"Citizenship: {Citizenship}");
        }
    }
}
