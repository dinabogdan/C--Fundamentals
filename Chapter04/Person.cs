using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string MiddleName { get; set; }

        public Person()
        {

        }

        public Person(string name, int age, string address, string phoneNo)
        {
            Name = name;
            Age = age;
            Address = address;
            PhoneNo = phoneNo;
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping at his/her home located at {Address}");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{Name} is eating {food} at his/her home located at {Address}");
        }
    }
}
