using System;
using System.Collections.Generic;
using System.Threading.Channels;
// 1:05:00
// метод расширения
// where sealed
// синтаксический сахар
// static
// getter and setter can't be set access higer level than all field
// конфликт пространство имен
// функция может влиять на ссылочный тип
namespace lesson_21_extension_method_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type number: ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                // var isEven = IsEven(result);
                // var isEven = result.IsEven();
                if (result.IsEven())
                {
                    Console.WriteLine($"{result} - Even.");
                }
                else
                {
                    Console.WriteLine($"{result} - Odd.");
                }
            }
            else
            {
                Console.WriteLine("This isn't integer number.");
            }

            int h = 182;
            h.isDivivdedBy(7);
            172.isDivivdedBy(2);

            #region Road

            var roads = new List<Road>();
            for (int i = 0; i < 10; i++)
            {
                var road = new Road();
                road.CreateRandomRoad(1000, 10000);
                roads.Add(road);
            }

            var roadsName = roads.ConvertToString();
            Console.WriteLine(roadsName);



            #endregion
        }
        /*static bool IsEven(int i)
        {
            return i % 2 == 0;
        }*/
    }
}