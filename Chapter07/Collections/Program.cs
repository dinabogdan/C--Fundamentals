using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;

namespace Collections
{
    internal class Program
    {
        static IEnumerable<int> Countdown(int start, int end)
        {
            for(int i = start; i >= end; --i)
            {
                yield return i;
            }
        }

        static void Main(string[] args)
        {
            // 1. Generic collections vs Raw collections

            // ArrayList - a raw collection
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("2");
            arrayList.Add(new { FirstName = "John" });

            // Hashtable - a raw collection
            Hashtable hashTable = new Hashtable();

            // var first = (string) arrayList[0]; - it will produce an InvalidCastException

            // List<T> - a generic collection
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);

            // Dictionary<TKey, TValue> - a generic
            Dictionary<string, int> stringToInts = new Dictionary<string, int>();
            stringToInts.Add("1", 1);

            // How to instantiate & initialize collections?
            List<int> conciseInts = new() { 1, 2, 3, 4, 5 };
            Dictionary<string, int> conciseStringToInts = new Dictionary<string, int>
            {
                ["1"] = 1,
                ["2"] = 2,
                ["3"] = 3
            };

            // 2. Immutable and ReadOnly collections

            // readonly collections
            ReadOnlyCollection<int> readonlyCollectionInts = new ReadOnlyCollection<int>(ints);
            ints.Add(3);
            Console.WriteLine($"Element on position 2: {readonlyCollectionInts[2]}");

            // immutable collections
            ImmutableArray<int> immutableArray = ImmutableArray.Create(new[] { 1, 2, 3, 4, 5 });
            var secondInstance = immutableArray.Add(6);
            Console.WriteLine($"Element on position 5: {secondInstance[5]}");

            // 3. Add elements to collections
            stringToInts.Add("2", 2);


            // 4. Updating collection elements
            ints[0] = 10;
            stringToInts["3"] = 3;

            Console.WriteLine($"Ints position 0 {ints[0]}");
            Console.WriteLine($"stringToInts key '3' {stringToInts["3"]}");

            // 5. Removing elements from collection
            stringToInts.Remove("3");
            // Console.WriteLine($"stringToInts key '3' {stringToInts["3"]}"); - it will produce IndexOutOfRangeException

            // Enumerators
            List<int>.Enumerator enumerator = ints.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            // is equivalent to
            foreach(var number in ints)
            {
                Console.WriteLine(number);
            }

            // Iterators
            foreach(int i in Countdown(5, 1))
            {
                Console.WriteLine(i);
            }
        }
    }
}
