using System;
// reference
// int i=5;
// i=7;
// int *j = &i;
// 
// * разыменование
// указатель адрес переменной в памяти
namespace lesson_30_unsafe_code_1
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int i = 30;
                int* address = &i;
                Console.WriteLine(*address);
                Console.WriteLine((long) address);
                int a = 5;
                int b = 7;
                
                Calc(a, &b);
                Console.WriteLine(a);
                Console.WriteLine(b);

                int* address2 = address + 4;
                Console.WriteLine(*address);
                Console.WriteLine();
                Console.WriteLine(*address2);

                Console.WriteLine("own");
                
                int number = 5;
                Console.WriteLine($"int {number}");

                int* numberAdr = &number;
                Console.WriteLine(*numberAdr);
                Console.WriteLine((long)numberAdr);
                Console.WriteLine((int)numberAdr);


            }
            
        }

        static unsafe void Calc(int i, int* j)
        {
            i = 500;
            *j = 700;
        }

        static void Calc(int i, ref int j)
        {
            //
        }
        
        
    }
}