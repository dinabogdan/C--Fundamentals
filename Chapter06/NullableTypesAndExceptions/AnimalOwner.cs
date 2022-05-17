namespace NullableTypesAndExceptions
{
    public class AnimalOwner
    {
        public string? Name { get; set; }
        public Dog? OwningDog { get; set; }
    }

    public class Dog
    {
        public string? Name { get; set; }
    }
}
