using System;

namespace TypeSystemDemo
{
    // Value Types vs Reference Types

    // 1. Value Types

    // 1.1 Enum as Value Type
    enum SomeEnum
    {
        A,
        B,
        C
    }

    // 1.2 Struct as Value Type
    struct SomeStruct
    {
        
    }

    // 2. Reference Types

    // 2.1 Class as Reference Type
    class SomeClass
    {
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            var someEnumValue = SomeEnum.A;
            var someStructValue = new SomeStruct();

            var someClassValue = new SomeClass();

            Console.WriteLine("Hello World!");
        }
    }
}
