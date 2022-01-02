using System;
// tuple and value-tuple
// reference type value type
// keep in heap and other state
// value stack
// reference heap
// instead tuple use class or struct
namespace lesson_23_tuple_anonymous_type
{
    class Program
    {
        static void Main(string[] args)
        {
            //seldom format
            Tuple<int, string> tuple = new Tuple<int, string>(5, "Hello");
            //tuple.Item1 = 5;
            // item1 item2 standard name for tuple
            // value tuple we can name
            // can not crate method
            // like class
            Console.WriteLine(tuple.Item1);
            var tuple2 = (5, "Привет");
            var tuple3 = (Name: "Tomato", Energy: 20);
            tuple3.Energy = 60;
            var result = GetData();
            Console.WriteLine(result.Name);


        }

        public static (int Number, string Name, bool Flag) GetData()
        {
            var number = 7821; // get data
            var name = Guid.NewGuid().ToString();
            bool b = number > 500;
            return (number, name, b);
        }
    }
}