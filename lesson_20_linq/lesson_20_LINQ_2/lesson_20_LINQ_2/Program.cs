using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace lesson_20_LINQ_2
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            #region Where
            var collection = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "Продукт"+i,
                    Energy=rnd.Next(10, 500)
                };
                collection.Add(product);
            }

            var result = from item in collection
                where item.Energy < 200
                orderby item.Energy
                select item;

            var result2 = collection.Where(item => item.Energy < 200 || item.Energy > 400);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Select_and_OrderBy
            IEnumerable<int> selectColletion = collection.Select(product => product.Energy);
            // на входе была коллекция продуктов на выходе коллекция каллорий
            foreach (var item in selectColletion)
            {
                Console.WriteLine(item);
            }

            var orderbyColection = collection.OrderBy(product => product.Energy);
            foreach (var item in orderbyColection)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region orderBySameValue
            var collection1 = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "Продукт"+i,
                    Energy=rnd.Next(10, 12)
                };
                collection1.Add(product);
            }

            var orderBySameCollection = collection1.OrderBy(item => item.Energy).ThenBy(product => product.Name);

            Console.WriteLine();
            foreach (var VARIABLE in orderBySameCollection)
            {
                Console.WriteLine(VARIABLE);
            }
            

            #endregion

            #region GroupBy

            var groupByCollection = collection1.GroupBy(product => product.Energy);
            foreach (var VARIABLE in groupByCollection)
            {
                Console.WriteLine($"Key: {VARIABLE.Key}");
                foreach (var item in VARIABLE)
                {
                    Console.WriteLine($"\t{item}");   
                }
            }


            #endregion

            #region Reverse

            /*collection1.Reverse();
            foreach(var VARIABLE in orderbyColection)
            {
                Console.WriteLine(VARIABLE);
            }*/
            
            


            #endregion

            #region ALL_AND_ANY
            Console.WriteLine(collection1.All(item => item.Energy == 10));
            Console.WriteLine(collection1.Any(item => item.Energy == 10));
            #endregion

            #region Contains
            // check by point
            Console.WriteLine("Contains:_______________________________________________________________");
            Console.WriteLine(collection1.Contains(collection1[5]));
            var prod = new Product();
            Console.WriteLine(collection1.Contains(prod));
            #endregion

            #region UNION
            Console.WriteLine("Union:_______________________________________________________________");
            var array = new int[]{1, 2, 3, 4};
            var array2 = new int[] {3, 4, 5, 6};
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("union");
            var union = array.Union(array2);
            foreach (var item in union)
            {
                Console.WriteLine(item);   
            }
            

            #endregion

            #region Intersect

            Console.WriteLine("intersect:_______________________________________________________________");

            var intersect = array.Intersect(array2);
            foreach (var VARIABLE in intersect)
            {
                Console.WriteLine(VARIABLE);
            }

            #endregion

            #region Except
            Console.WriteLine("except:_______________________________________________________________");

            var except = array.Except(array2);
            foreach (var VARIABLE in except)
            {
                Console.WriteLine(VARIABLE);
            }
            
            #endregion

            #region Sum_MIN_max_so_on
            Console.WriteLine("SUM:_______________________________________________________________");

            var sum = array.Sum();
            var min = collection1.Min(p => p.Energy);
            var max = collection1.Max(p => p.Energy);
            var aggregate = array.Aggregate((x, y) => x * y);
            var sum2 = array.Skip(1).Sum();//count of skipped element
            var sum3 = array.Take(2).Sum();//count of selected

            var first = array.First();//if empty exception
            var first2 = array.FirstOrDefault();//int 0 null
            var last = array.Last();
            var last2 = array.LastOrDefault();
            // where return null or collection or least one
            // ToList()

            var single = collection1.Single(product=>product.Energy==10);
            // first product whose energy equals to 10 and there is only one like this

            var elementAt = collection1.ElementAt(5); // by collection number 






            #endregion


        }
    }
}