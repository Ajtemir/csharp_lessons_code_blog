using System;

namespace lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6 парадигм правила
            // функционально-процедурный
            // несколько команд в функции
            // следующий этап это ооп
            // каркас 
            // чертёж
            //
            // 1
            // инкапсуляция сокрытие данных
            // чёрный ящик 
            // public private protected
            //
            // 2
            // наследование
            // люди врачи программисты + профессия
            // все перетекает в наследник
            // 
            // 3
            // полиморфизм
            // в первую очередь базовый
            // 
            // 4
            // абстракция
            // второстенное если нужно то берем
            // 
            // 5
            // посылка сообщений
            //
            // 6
            // повторное использование кода
            // 

            class Person
            {
                // public // открытый
                // internal // открытый в пределах проекта
                // protected // защищённый
                // private // закрытый не наследнику

                public string firstName;
                public string LastName;
                private decimal money;




            }
            Person person = new Person();
            person.LastName = "Aytemir";

            public class Doctor : Person{
                public string spesialization; 
            }
            Doctor doctor = new Doctor();
            doctor.LastName = 23;
            // protected можем использовать внутри доктора
            // наследование от одного класса
            Person p = doctor;
            // p.spesialization don't work
            Doctor dd = (Doctor)p;
            // dd.spesialization work 
            // 



        }
    }
}
