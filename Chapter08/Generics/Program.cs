using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

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

        static Cage<T> ANewCage<T>(T animal, double size) => new Cage<T> { Animal = animal, Size = size };

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

            // 1. Generic method (static or as an instance method)
            var secondCage = ANewCage(dog, 1.0);

            // 2. Generic extension method
            var listOfInts = new List<int> { };
            listOfInts.AddOneElement(1);

            // 3. Variance

            // 3.1 Covariance
            var tvProducer = new TVProducer();
            var phoneProducer = new PhoneProducer();
            IProducer<Item> tvProducer2 = new TVProducer();

            // 3.2 Contravariance
            var computerCategoryOwner = new ComputerCategoryOwner();
            var tvCategoryOwner = new TVCategoryOwner();

            var tvMarketCategory = new ItemMarketCategory<TV> { CategoryOwner = tvCategoryOwner };
            tvMarketCategory.AddPrice(new TV { Brand = "Samsung" }, 1000);
            tvMarketCategory.AddPrice(new TV { Brand = "LG" }, 900);

            var computerMarketCategory = new ItemMarketCategory<Computer> { CategoryOwner = computerCategoryOwner };
            computerMarketCategory.AddPrice(new Computer { Brand = "Apple Macbook Pro" }, 1000);

            var phoneCategoryOwner = new ItemCategoryOwner{  };
            var phoneMarketCategory = new ItemMarketCategory<Phone> { CategoryOwner = phoneCategoryOwner }; // compile-time error


        }
    }
}
