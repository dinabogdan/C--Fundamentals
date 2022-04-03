using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOP
{
    public abstract class Car
    {
        public string Manufacturer { get; init; }
        public string Color { get; init; }
        public int Year { get; init; }

        public abstract string Description { get; init; }

        public void Start()
        {
            Console.WriteLine("Vrum, Vrum! Engine is starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Engine is stopping ...");
        }

        public abstract void Honking();
    }

    public class Ferrari : Car
    {
        public override string Description
        {
            get => "This is a sports car!";
            init { }
        }

        public override void Honking()
        {
            Console.WriteLine("A Ferrari is honking!");
        }
    }

    public class RollsRoyce : Car
    {
        public override string Description
        {
            get => "This a luxurious car!";
            init { }
        }

        public override void Honking()
        {
            Console.WriteLine("A Rolls-Royce is honking!");
        }
    }
}
