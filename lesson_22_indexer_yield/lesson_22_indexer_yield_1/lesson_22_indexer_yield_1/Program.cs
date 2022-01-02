using System;
using System.Collections.Generic;

// 21:00
// индексатор запрос к коллекции
// перегрузка возможна
// это обёртка

namespace lesson_22_indexer_yield_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car() {Name = "Ford", Number = "A001AA01"},
                new Car() {Name = "Lada", Number = "B727ET77"},
            };

            var parking = new Parking();
            foreach (var car in cars)
            {
                parking.Add(car);
            }

            foreach (var name in parking.GetNames())
            {
                Console.WriteLine("Name "+name);
            }
            Console.WriteLine();
            foreach (var car in parking)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();
            Console.WriteLine(parking["A001AA01"]?.Name);
            Console.WriteLine(parking["A001AdA01"]?.Name);

            Console.WriteLine("Type new car auto:");
            var num = Console.ReadLine();
            parking[1] = new Car() {Name = "BMW", Number = num};
            Console.WriteLine(parking[1]);
        }
    }
}