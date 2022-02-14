using System;
using CodingConventionsDemo.SomeNamespace;

namespace CodingConventionsDemo
{
    // PascalCase naming for classes
    class SomeClass
    {

    }

    // PascalCase naming for structs
    struct SomeStruct
    {

    }

    // Naming convention for interfaces (C# vs Java)
    interface ISomeInterface
    {

    }

    public class CustomerService
    {
        // 1. Public field (PascalCase)
        public bool SomeBoolField;

        // 2. Private field (camelCase)
        private bool somePrivateField;

        // 3. Public property (PascalCase)
        public bool SomeBoolProperty { get; set; }

        // 4. Public method (PascalCase)
        public void SomeMethod()
        {
            // 4.1 Local method (PascalCase)
            void SomeLocalMethod()
            {

            }
        }

        // 5. Avoid using `this` operator
        public void SomeMethod2()
        {
            SomeBoolField = false;
        }

        // 6. Specify visibility access level

        // 7. Use type-inference and `var` keyword
        public void SomeMethodExample()
        {
            var example = 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AnotherClass anotherClassInstance = new AnotherClass();

            var x = 0;
            var y = 0;

            // Curly braces indentation style
            if (x == y) 
            {
                Console.WriteLine("X is equal to Y");
            }
        }
    }
}
