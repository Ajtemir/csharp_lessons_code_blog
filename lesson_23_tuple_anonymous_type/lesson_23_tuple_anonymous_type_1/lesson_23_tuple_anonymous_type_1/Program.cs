using System;
// anonymous type - синтаксический сахар
// negative seldom usable
//  

namespace lesson_23_tuple_anonymous_type_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 5;
            var product = new // anonymous type
            {
                Name = "Milk",
                Energy = 10
            };
            // can not change value, object isn't changed
            // never user dynamic
            // little container for keeping data
            // product.Energy = 55;
            Console.WriteLine(product);
            Console.WriteLine(product.Energy);
            Console.WriteLine(product.Name);

            var eat = new Eat()
            {
                Name = "Meat"
            };

            var product2 = new
            {
                eat.Name,
                Energy = 200
            };
            Console.WriteLine(product2);
        }
    }
}