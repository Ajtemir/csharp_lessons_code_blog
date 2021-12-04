using System;

namespace lesson_15_delegate_event
{   
    // public delegate type_returning_data name_delegate(type_argument argument)
    
    
    
    class Program
    {
        public delegate void MyDelegate();
        public Action ActionDelegate;
        public event MyDelegate Event;
        // public event Action EventAction;
        // equivalent
        
        public delegate int ValueDelegate(int i);
        static void Main(string[] args)
        {
            #region delegate 
            // переменная для функции - контейнер
            // коллекция таких переменных
            // сигнатура аргументы которые он принимает и количество
            // void and int

            MyDelegate myDelegate = Method1;
            // myDelegate += Method4;
            MyDelegate myDelegate2 = new MyDelegate(Method4);
            
            myDelegate2 += Method4;
            myDelegate2 -= Method4;
            
            myDelegate();
            myDelegate2.Invoke();
            MyDelegate myDelegate3 = myDelegate + myDelegate2;
            myDelegate3.Invoke();

            var valueDelegate = new ValueDelegate(MethodValue);
            valueDelegate += MethodValue;
            valueDelegate += MethodValue;
            valueDelegate += MethodValue;
            valueDelegate += MethodValue;
            valueDelegate((new Random()).Next(10, 50));
            Action action = Method1;
            // Action<int> action2 = MethodValue();
            action();
            
            //Predicate <int> predicate;
            // only one argument
            // public delegate bool Predicate<T>(T value);

            // Func<string, int> func;
            // public delegate int Func(string value);
            // return any value
            // can be no argument
            Func<int, int> func = MethodValue;
            func?.Invoke(7);
            #endregion
            //EVENT
            // изменение системы
            // разработчик изменения
            Person person = new Person();
            person.GoToSleep += PersonOnGoToSleep;
            person.TakeTime(DateTime.Parse("27.12.2018 21:13:01"));
            person.TakeTime(DateTime.Parse("27.12.2018 4:13:01"));





        }

        private static void PersonOnGoToSleep()
        {
            Console.WriteLine("go to sleep");
            Console.ReadLine();
        }

        public static int MethodValue(int i)
        {
            Console.WriteLine(i);
            return i;
        }
        public  static void Method1()
        {
            Console.WriteLine("Method_1");
        }
        public  static int Method2()
        {
            Console.WriteLine("Method_2");
            return 0;
        }
        public  static void Method3()
        {
            Console.WriteLine("Method_3");
        }
        public  static void Method4()
        {
            Console.WriteLine("Method_4");
        }
        
    }
}