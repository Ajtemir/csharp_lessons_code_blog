using System;
using System.Collections.Generic;
using System.Linq;

/*
 * delegate is good
 * anonymous method is bad
 */
namespace lesson_24_method_lambda_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region first
            
            /*var lesson = new Lesson("Programming c#");
            lesson.Started += (sender, date) => // sender object date argument
            {
                Console.WriteLine(sender);
                Console.WriteLine(date);
            };
            lesson.Start();*/
            
            #endregion

            #region second

            var list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }
            var res = list.Aggregate((x, y) => x + y);
            Console.WriteLine(res);

            var result1 = Agr(list, delegate(int i)
            {
                var r = i * i;
                Console.WriteLine(r);
                return r;

            });

            // var result2 = Agr(list, Method);
            var result = Agr(list, x => x * x * x * x);

            #endregion

        }

        public delegate int MyHandler(int i);

        public static int Agr(IList<int> list, MyHandler handler)
        {
            var result = 0;

            foreach (var item in list)
            {
                result += handler(item);
            }

            return result;
        }
    }
}