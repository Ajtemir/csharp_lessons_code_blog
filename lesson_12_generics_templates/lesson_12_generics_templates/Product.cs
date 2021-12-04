namespace lesson_12_generics_templates
{
    public class Product<T, TT>
    {
        public string Name { get; set; }
        public T Volume { get; set; }
        public TT Energy { get; set; }

        public Product(string name, T volume, TT energy)
        {
            // TODO: check input data
            Name = name;
            Volume = volume;
            Energy = energy;
        }
    }

    public class Fruit
    {
        public string Name { get; set; }
        public int Volume { get; set; }
        public int Energy { get; set; }

        public Fruit(string name, int volume, int energy)
        {
            Name = name;
            Volume = volume;
            Energy = energy;
        }
    }
}