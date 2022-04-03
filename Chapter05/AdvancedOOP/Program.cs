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

            Car ferrari = new Ferrari
            {
                Color = "Red",
                Manufacturer = "Ferrari",
                Year = 2020,
            };

            Car rollsRoyce = new RollsRoyce
            {
                Color = "Black",
                Manufacturer = "RollsRoyce",
                Year = 2022
            };

            ferrari.Start();
            ferrari.Honking();
            ferrari.Stop();

            rollsRoyce.Start();
            rollsRoyce.Honking();
            rollsRoyce.Stop();

            Console.WriteLine(ferrari.Description);
            Console.WriteLine(rollsRoyce.Description);
        }
    }
}
