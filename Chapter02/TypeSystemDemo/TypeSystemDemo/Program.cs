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

            // Basic Types
            System.Byte oneByte = 1;
            byte byteInCSharp = 1;

            System.Int32 oneInt32 = 32;
            int int32InCSharp = 32;

            // byte <=> System.Byte - 8 bits

            byte someByte = 10;
            Console.WriteLine($"typeof(someByte)={someByte.GetType()}; minValue(byte)={byte.MinValue}; maxValue(byte)={byte.MaxValue}");

            // sbyte <=> System.SByte - 8 bits
            sbyte someSignedByte = -10;
            Console.WriteLine($"typeof(someSignedByte)={someSignedByte.GetType()}; minValue(sbyte)={sbyte.MinValue}; maxValue(sbyte)={sbyte.MaxValue}");

            // ushort <=> System.UInt16 - 16 bits
            ushort someUnsignedShort = 19;
            Console.WriteLine($"typeof(someUnsignedShort)={someUnsignedShort.GetType()}; minValue(ushort)={ushort.MinValue}; maxValue(ushort)={ushort.MaxValue}");

            // short <=> System.Int16 - 16 bits
            short someShort = -30;
            Console.WriteLine($"typeof(someShort)={someShort.GetType()}; minValue(short)={short.MinValue}; maxValue(short)={short.MaxValue}");

            // uint <=> System.UInt32 - 32 bits
            uint someUnsignedInt = 1000;
            Console.WriteLine($"typeof(someUnsignedInt)={someUnsignedInt.GetType()}; minValue(uint)={uint.MinValue}; maxValue(uint)={uint.MaxValue}");

            // int <=> System.Int32 - 32 bits
            int someInteger = -1000;
            Console.WriteLine($"typeof(someInteger)={someInteger.GetType()}; minValue(int)={int.MinValue}; maxValue(int)={int.MaxValue}");

            // ulong <=> System.UInt64 - 64 bits
            ulong someUnsignedLong = 1000000;
            Console.WriteLine($"typeof(someUnsignedLong)={someUnsignedLong.GetType()}; minValue(ulong)={ulong.MinValue}; maxValue(ulong)={ulong.MaxValue}");

            // long <=> System.Int64 - 64
            long someLong = -1000000;
            Console.WriteLine($"typeof(someLong)={someLong.GetType()}; minValue(long)={long.MinValue}; maxValue(long)={long.MaxValue}");
        }
    }
}
