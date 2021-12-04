using System;

namespace lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // методы это действия которые может совершить 
            // эксземляр класса или над эксземляром класса
            // актив и пассив

            // function is method void or return something

            // модификатор доступа тип_возвращаемого значения имя_метода(тип аргумента имя аргумента)
            // возвращаемое значение мы не должны сохранять

            // static общий для всех экземпляров

            // объязательно проверяем тип трай и кетч входных данных

            // конструктор ничего не возвращает 

            // нужно писать тесты

            // перегрузка методов одним именем без сигнатур

            //
            // var i = PrintHello("Вадим", 27);
            // Console.WriteLine(i);
            //

            // Recursion
            // вызов метода самого себя
            // error stackoverflow
            public int Factorial(int value)
            {
                if(value <= 1)
                {
                    return 1;
                }
                else
                {
                    return value Factorial(value - 1);
                } 
            }

            var person1 = new Person("Иванов", "Иван");
            var person2 = new Person("Петров", "Пётр");

            for(var i=0; i < 10; i++)
            {
                var position1 = person1.Run();
                Console.WriteLine(position1);

                var position2 = person2.Run();
                Console.WriteLine(position2);
            }

            Console.WriteLine();
            Console.ReadLine();




        }
        // public static int PrintHello(string name, int age)
        // {
        //     Console.WriteLine($"Привет, {name}, вам {age} лет/");
        //     return 1;
        // }
        
    }
}
