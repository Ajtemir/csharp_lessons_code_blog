using System;
using System.Collections;
using System.Linq;

namespace lesson_21_extension_method_1 // must to connect namespace
{
    public static class Helper // static must used
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }

        public static bool isDivivdedBy(this int i, int j)
        {
            return i % j == 0;
        }

        public static string ConvertToString(this IEnumerable collection)
        {
            var result = "";
            foreach (var item in collection)
            {
                result += item.ToString() + ", \n\r";
            }
            return result;
        }

        public static Road CreateRandomRoad(this Road road, int min, int max)
        {
            // var rnd = new Random(DateTime.Now.Millisecond);
            var rnd = new Random(Guid.NewGuid().ToByteArray().Sum(x=>x));
            road.Number = "M" + rnd.Next(1, 100);
            road.Length = rnd.Next(min, max);
            return road;
        }
        
    }
}