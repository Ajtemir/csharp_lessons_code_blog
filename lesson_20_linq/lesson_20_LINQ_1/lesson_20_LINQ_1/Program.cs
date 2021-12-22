using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson_20_LINQ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // orm
            // work with data from collections entity json xml
            // язык запросов с помощью сишарп
            // method is added over class methods extensions
            // interface IEnumerable is used with foreach and collection
            var collection = new List<int>();
            for (var i = 0; i < 10; i++)
            {
                collection.Add(i);
            }
            // 1st way
            var result = from item in collection
                where item < 5
                select item;// не список а набор элементов
            // 2nd way
            var result2 = collection.Where(item => item < 5);
                //.Where(item => item % 2 == 0)
                //.OrderByDescending(item=>item)
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            
            
        }
    }
}