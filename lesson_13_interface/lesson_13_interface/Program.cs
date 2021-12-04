using System;
using System.Collections.Generic;
namespace lesson_13_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // интерфейс - открытый способ взаимодействия с чем-то
            // microwave button start
            // steering wheel and pedal of car
            // method indexer event property type of interface
            // not private
            // accessible to all
            // name with uppercase letter I this is advice
            // интерфейсы не наследуются
            // они реализуются или инрементируются
            // в телефоне есть кучу интерфейсов
            // msdn
            // наследование интерфейса от интерфейса объявлять методы 
            // реализация нескольких интерфейсов
            var cars = new List<ICar>();
            cars.Add(new LadaSeven());
            cars.Add(new BmwSeven());

            foreach (var car in cars)
            {
                // ((LadaSeven)car)
                Console.WriteLine(car.Move(200));
            }

            Cyborg cyborg = new Cyborg();
            Console.WriteLine(((ICar)cyborg).Move(100));
            Console.WriteLine(((IPerson)cyborg).Move(100));

        }
    }
}