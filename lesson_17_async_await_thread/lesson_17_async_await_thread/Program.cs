using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lesson_17_async_await_thread
{
    class Program
    {
        public static object locker = new object();
        public static int i1 = 100;

        static void M1()
        {
            for (int i = i1; i >= i1; i++)
            {
                
            }
        }
        static void M2()
        {
            for (int i = 0; i >= i1; i--)
            {
                
            }
            
        }
        static void Main(string[] args)
        {
            /* locker
            lock (locker)
            {
                var rnd = new Random();
                var text = "";
                for (int i = 0; i < 5000; i++)
                {
                    text += rnd.Next();
                }
            }

            using (var sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.WriteLine();
            }
            */
            
            /*
            DoWorkAsync();
            int j = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                j++;
                if (j % 1000 == 0)
                {
                    Console.WriteLine("Main");
                }
            }
            Console.ReadKey(); */
            /*
            Console.WriteLine("Begin main");
            DoWorkAsyncParam(10);
            // DoWorkAsync();
            Console.WriteLine("Continue main");
            //int j = 0;
            for (int i = 0; i < 10; i++)
            {
                
                    Console.WriteLine("Main");
                
            }
            Console.WriteLine("end main");
            Console.ReadKey();
            */
            // конкурентность - за одни и те же ресурсы
            // друг на друга не влияют, не взаимодействуют
            // 2 приложения за монитор

            // парралельное испольнение
            // внутри одного приложения выделить несколько 
            // обособленных частей, выполнятся ассинхронно
            // в конце сойдутся
            // внутри программы выполнение отдельных участков кода
            // траншея в две стороны

            // многопоточность - для процессора выделить один поток
            // основной поток и вычисление паралельно
            // взаимодействие нескольких потоков
            // ответственность несем мы

            // ассинхронность
            // участок кода - задача, функция
            // после колбэк
            // основной поток 
            // thread pool
            // ресурсоёмкий
            // нет тонкой настройки

            // #region endregion
            /* многопоточность */
            // Thread thread = new Thread(new ThreadStart(DoWork));
            // thread.Start();
            // Thread thread2 = new Thread(new ParameterizedThreadStart(DoWork));
            // thread2.Start(int.MaxValue);
            // int j = 0;
            // for (int i = 0; i < int.MaxValue; i++)
            // {
            //     j++;
            //     if (j % 1000 == 0)
            //     {
            //         Console.WriteLine("Main");
            //     }
            // }
            // Console.ReadKey();
            
            // deadlock
            // yama 2 na 2 metra dva man it is normal
            // 50 men into one this is anormal
            // 2 object to one uvhastok pamyati
            // два потока взаимодействуют с друг другом
            
            
            //async
            // Task<int>
            /*
            var result = SaveFileAsync("test.txt");
            var input = Console.ReadLine();
            Console.WriteLine(result.Result);
            */


        }

        static async Task<bool> SaveFileAsync(string path)
        {
            var result = await Task.Run(() => SaveFile((path)));
            return result;
        }
        
        static bool SaveFile(string path)
        {
            var rnd = new Random();
            var text = "";
            for (int i = 0; i < 10000; i++)
            {
                text += rnd.Next();
            }

            using (var sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.WriteLine();
            }

            return true;
        }
        
        
        /* before one hour */
        static async Task DoWorkAsync()
        {
            Console.WriteLine("Begin Async");
            await Task.Run((() => DoWorkTen()));
            Console.WriteLine("End Async");
        }
        
        static async Task DoWorkAsyncParam(int maxt)
        {
            Console.WriteLine("Begin Async");
            await Task.Run((() => DoWorkParametr(maxt)));
            Console.WriteLine("End Async");
        }

        static void DoWorkParametr(int max)
        {
            //int j = 0;
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("DoWorkParameter");
            }
        }

        static void DoWork()
        {
            int j = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                j++;
                if (j % 1000 == 0)
                {
                    Console.WriteLine("DoWork");
                }
            }
        }
        static void DoWorkTen()
        {
            //int j = 0;
            for (int i = 0; i < 10; i++)
            {
               
                    Console.WriteLine("DoWork");
                
            }
        }
        static void DoWork(object max)
        {
            
            int j = 0;
            for (int i = 0; i < (int)max; i++)
            {
                j++;
                if (j % 1000 == 0)
                {
                    Console.WriteLine("DoWork2");
                }
            }
        }
        
    }
}