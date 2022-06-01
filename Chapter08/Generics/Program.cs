using System;

namespace Generics
{
    class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }

    class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }

    class Cage<TAnimal>
    {
        public TAnimal Animal { get; set; }
        public double Size { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog
            {
                Id = 1,
                Name = "Spark",
                Color = "Black"
            };

            var cat = new Cat
            {
                Id = 1,
                Name = "Tom",
                Color = "Orange"
            };

            var dogCage = new Cage<Dog>
            {
                Animal = dog,
                Size = 1.0
            };

            var catCage = new Cage<Cat>
            {
                Animal = cat,
                Size = 0.5
            };
        }
    }
}
