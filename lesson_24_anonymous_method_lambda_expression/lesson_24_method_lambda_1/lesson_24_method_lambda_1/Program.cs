using System;
/*
 * у него нет имени у анонимного метода
 * его контейнер делегат
 * не нравиться
 * динамически менять метод
 * лямбда более красивый синтаксис
 * использовать несколько раз
 */

namespace lesson_24_method_lambda_1
{
    class Program
    {
        delegate int MyHandler(int i);
        static void Main(string[] args)
        {
            #region first

            

            /*if (int.TryParse(Console.ReadLine(), out int result)) 
            {
                MyHandler handler = delegate(int i)
                {
                    var r = i * i;
                    Console.WriteLine(r);
                    return r; 
                };
                //handler += Method;
                handler(result);
                handler(88);
            }

            Console.ReadLine();
            Method(88);
            */
            
            #endregion

            #region lambda
            
            // MyHandler lambdaHandler = (i) => i * i;
            // динамически меняется тип
            
            MyHandler lambdaHandler = (i) => 
            {
                var r = i * i;
                Console.WriteLine(r);
                return r;
            };

            lambdaHandler(99);

            #endregion



        }

        public static int Method(int i)
        {
            var r = i * i * i;
            Console.WriteLine(r);
            return r; 
        }
    }
}