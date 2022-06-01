using System;
using System.Collections.Generic;

namespace Generics
{
    public class Item
    {
        public virtual string Brand { get; set; }
    }

    public class TV : Item
    {
        public override string Brand { get; set; }
    }

    public class Computer : Item
    {
        public override string Brand { get; set; }
    }

    public class Phone : Item
    {
        public override string Brand { get; set; }
    }

    interface IProducer<out T>
    {
        T Produce();
    }

    class TVProducer : IProducer<TV>
    {
        public TV Produce()
        {
            return new TV { Brand = "Samsung" };
        }
    }

    class PhoneProducer : IProducer<Phone>
    {
        public Phone Produce()
        {
            return new Phone { Brand = "Apple" };
        }
    }

    class ComputerProducer : IProducer<Computer>
    {
        public Computer Produce()
        {
            return new Computer { Brand = "Apple MacBook" };
        }
    }

    // ---------------------------------------------------------------------------------------- //

    interface ICategoryOwner<in T> where T : Item
    {
        public void RemoveItem(T item)
        {
            Console.WriteLine($"Just removed {item}");
        }

        public void AddItem(T item, decimal price)
        {
            Console.WriteLine($"Just added {item} with price {price}");
        }
    }

    class ItemCategoryOwner : ICategoryOwner<Item>
    {

    }

    class TVCategoryOwner : ICategoryOwner<TV>
    {

    }

    class ComputerCategoryOwner : ICategoryOwner<Computer>
    {

    }

    class PhoneCategoryOwner : ICategoryOwner<Phone>
    {

    }

    class ItemMarketCategory<T> where T : Item
    {
        public ICategoryOwner<T> CategoryOwner { get; set; }
        public Dictionary<T, decimal> Prices = new();

        public void AddPrice(T item, decimal price)
        {
            CategoryOwner.AddItem(item, price);
            Prices[item] = price;
        }
    }
}
