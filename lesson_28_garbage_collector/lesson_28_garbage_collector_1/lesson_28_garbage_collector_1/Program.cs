using System;
//41:00
// reference => stack(fast, limited by memory)
// valueable => heap(slow, nearly all RAM)

// trivial data type int char etc keep in stack
// for own class used heap

// ячейка памяти в памяти ordered
// for address => stack
// method frame duplicate 
// CW(i); => copy i
// Garbage collector gives up working
// new выделяет память
// есть три поколения 0 1 2
// не проверяет всё
// new = 0 
// if "new" has reference = 1 if пережил очистку
// if little memory level up 2 if пережил 1-ое
// long live is good  
// not always
// object in heap
// struct stack
// gluck
// seldom collect anyway
// утечка ручная
// static heap or stack
// large heap 
// usual heap
// IDispossible
// 

namespace lesson_28_garbage_collector_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GC.Collect(2);
        }
    }
}