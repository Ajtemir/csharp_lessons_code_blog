using System;
using System.Linq;
// attribute отмечаем что только нужно для сериализации
// тип запроса get post
// string? can be used
namespace lesson_24_attribute_reflection_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo("hello.png")
            {
                Path = @"/home/aitemir/other_documents/"

            };
            
            var type = typeof(Photo);
            var attributes = type.GetCustomAttributes(false);
            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }

            var properties = type.GetProperties(); // return all property of class
            foreach (var prop in properties)
            {
                var attrs = prop.GetCustomAttributes(false);

                if (attrs.Any(a => a.GetType() == typeof(GeoAttribute)))
                {
                    Console.WriteLine(prop.PropertyType+ " "+ prop.Name);
                }
                
                /*foreach (var a in attrs)
                {
                    Console.Write(a);
                }*/
            }

        }
    }
}