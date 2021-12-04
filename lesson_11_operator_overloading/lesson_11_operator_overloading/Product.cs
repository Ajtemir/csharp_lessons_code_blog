using System;
namespace lesson_11_operator_overloading
{
    public abstract class Product
    {
        public string Name { get; }  // read only
        public int Calorie { get; } // read only
        public int Volume { get; set; }

        public double Energy
        {
            get
            {
                return Volume * Calorie / 100;
            }
        }

        protected Product(string name, int calorie, int volume)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (calorie < 0)
            {
                throw new ArgumentNullException();
            }

            if (volume <= 0)
            {
                throw new ArgumentNullException();
            }

            Name = name;
            Calorie = calorie;
            Volume = volume;



        }
        public override string ToString()
        {
            return $"{Name}. Калорийность {Calorie}, объём {Volume}";
        }
        
    }
}