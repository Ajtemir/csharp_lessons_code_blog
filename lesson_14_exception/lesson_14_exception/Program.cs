using System;

namespace lesson_14_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            // болевой эффект сигнализатор что-то пошло не так
            // нет того что должно быть
            // ожидаемые ошибки и исключения

            // пример
            // возраст человека отрицательный это ожидаемая ошибка
            // возраст двести лет это ожидаемая ошибка
            // деление на ноль исключение
            // отловили и сохранили от большего зла

            // finally необъязательно
            // int a = 20000000;   
            // int b = 20000000;
            // int c = checked(a * b);
            // переполнение

            // There are many catches
            // catch(Exception ex) // это в конце
            // throw new DivideByZeroException();
            // catch(Exception ex) when (i==5)
            // дополнительная проверка фильтр исключений
            // own exception inherit from any class
            try
            {
                throw new MyOwnEception();
                throw new DivideByZeroException("Error bro ");
                //var i = 5;
                //var j = i / 0;
                //Console.WriteLine(j);
            }
            catch(MyOwnEception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) when (i==5) // можно catch // catch(type exception)
            {
                Console.WriteLine(ex.Message);
                throw; 
            }
            
            finally
            {
                Console.WriteLine("Work ended");
                int a = 20000000;
                int b = 20000000;
                int c = checked(a * b);
                Console.WriteLine(c);
                Console.ReadKey();
            }
            
            
        }
    }
}