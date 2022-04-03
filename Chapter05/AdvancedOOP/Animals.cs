using System;

namespace AdvancedOOP
{
    public class Animal
    {
        public string Name { get; init; }
        public string Food { get; init; }
        public string Habitat { get; init; }

        private int _hunger = 10;

        public virtual void MakeNoise()
        {
            Console.WriteLine($"The animal {Name} is making noise!");
        }

        public void Eat()
        {
            Console.WriteLine($"The animal {Name} is eating {Food}");
        }

        public void Sleep()
        {
            Console.WriteLine($"The animal {Name} is sleeping in {Habitat}");
        }
    }

    public class Dog : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine($"The dog {Name} is making noise!");
        }

        public bool HasCollar { get; init; }
    }
}
