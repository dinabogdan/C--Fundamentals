namespace Chapter04
{
    public struct TShirtSizeStruct
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public TShirtSizeStruct(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString() => $"Size {Name} has value {Value}";
    }
}
