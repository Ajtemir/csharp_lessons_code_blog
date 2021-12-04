using System;


namespace lesson_11_operator_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // перегрузка = переопределение, группа родственных объектов
            // абстрактный для наследования
            // не создаются экземпляры но может быть конструктор
            // бинарные + - / * %
            // логические два
            // унарные инкремент и декремент
            // += -=
            // необъязательно схожий тип
            // 
            
            

            Apple apple = new Apple("Красное яблоко", 100, 100);
            Apple apple2 = new Apple("Зеленое яблоко", 90, 100 );

            var sumApple = Apple.Add(apple, apple2);
            var sumApple2 = apple + apple2;
            
            Console.WriteLine(apple);
            Console.WriteLine(apple2);
            Console.WriteLine(sumApple);
            Console.WriteLine(sumApple2);
            Console.WriteLine();
            Console.WriteLine(apple == apple2);
            Console.WriteLine(sumApple == sumApple2);



        }
    }
    
    
}