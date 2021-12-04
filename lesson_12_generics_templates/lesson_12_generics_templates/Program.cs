using System;
using System.Collections.Generic;

namespace lesson_12_generics_templates
{
    class Program
    {
        static void Main(string[] args)
        {
            // шаблоны = универсальные типы
            // переменная для типа переменных
            // динамика в окружении строгости
            // use TODO
            // 100.0M decimal
            // <T>, <T, TT>
            // where
            // struct keeps in stack datetime
            // new() class struct
            // default(T)
            // bool false
            // string null
            // int 0
            // there is return

            var p = new Product<int, int>("Яблоко", 100, 100);
            var pp = new Product<decimal, int>("Банан", 10.1M, 1100);

            var eating = new Eating<Banana,List<int>>();
            
            var list = new List<int>();
            var map = new Dictionary<int, string>();
            map.Add(5, "Five");
        }
    }
}