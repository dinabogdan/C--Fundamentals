using System;

namespace AdvancedOOP
{
    public class Base
    {

    }

    public class Derived : Base
    {

    }

    public class MoreDerived : Derived
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal { Name = "Tom", Food = "CatFood", Habitat = "House" };
            Animal dog = new Dog { Name = "Berkley", Food = "DogFood", Habitat = "House", HasCollar = true };

            cat.MakeNoise();
            dog.MakeNoise();
        }
    }
}
