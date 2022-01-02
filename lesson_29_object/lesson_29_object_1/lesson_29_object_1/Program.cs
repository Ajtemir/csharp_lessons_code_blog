using System;
using bb = System.Int32; // carefully use
// object = base class
// valuable from object
// general base
// System.Object =psevdonim> object
// System.Int64 == int
// 
// box unbox
// null == null => true
// equal and == одинаковое поведение
//
// GetHashCode
// коллизия 
// hashcode difference it is good
// 
namespace lesson_29_object_1
{
    // class Program : System.Object
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();
            int i = 5;
            int j = 5;

            i.Equals(j);

            Console.WriteLine(i.Equals(j));
            var oi = (object) i;
            object oj = (object) j;
            Console.WriteLine(oi.Equals(oj));

            var p1 = new Point(){X=5};
            var p2 = new Point() {X = 5};
            Console.WriteLine(p1.Equals(p2));
            
            Console.WriteLine(i.GetHashCode()); // 5
            Console.WriteLine(oi.GetHashCode()); // 5
            Console.WriteLine(new MyClass().GetHashCode()); // 58225482
            Console.WriteLine(p1.GetHashCode()); // 5

            Console.WriteLine(p1.ToString());
            Console.WriteLine(i.ToString());

            Console.WriteLine(p1.GetType());
            
            Console.WriteLine(oj.GetType());
            
            // 2 method get type
            // getType isnt virtual 
            // override is for only virtual
            // after doing override used in base class, also descendant class
            
            Console.WriteLine("Typeof");
            Console.WriteLine(typeof(Point) == p1.GetType());
            Console.WriteLine("object");
            Console.WriteLine(p1.GetType());
            var new_obj = (object) p1;
            var n = (Point) new_obj;
            Console.WriteLine(new_obj.GetType());
            Console.WriteLine(n.GetType());
            Console.WriteLine("override");
            Console.WriteLine(p1);
            var d = (object) p1;
            Console.WriteLine(d);

            Console.WriteLine("object static");
            Console.WriteLine(Object.Equals(5,5));
            Console.WriteLine(Object.ReferenceEquals(5,5));
            Console.WriteLine(Object.ReferenceEquals(p2,p2));
            
            // clones
            Console.WriteLine("clones");
            // same object diffrent psevdonim
            // deep cloning
            // non deep cloning
            var pp = new Point()
            {
                X = 7
            }; 
            var pp2 = pp;
            pp2.X = 77;
            pp2.Y = new Point(){X=99};//
            Console.WriteLine(pp);
            Console.WriteLine(pp.Y);//
            var pp3 = pp.Clone();
            pp3.X = 88;//
            pp3.Y.X = 222;//
            Console.WriteLine(pp);
            Console.WriteLine(pp.Y);
            // 77 
            // 77
            
            // 99
            // 222




        }
    }
}