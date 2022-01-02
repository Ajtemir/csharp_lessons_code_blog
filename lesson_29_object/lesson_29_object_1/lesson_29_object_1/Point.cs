using System;

namespace lesson_29_object_1
{
    public class Point
    {
        public int X { get; set; }
        public Point Y { get; set; }

        public override bool Equals(object? obj)
        {
            // never raise exception
            if (obj == null) return false;
            // is if(obj is Point) => true
            // as 
            var point = obj as Point; // если не сможем преоброзовать получим null
            if (point != null)
            {
                return X == point.X;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return X;
        }

        // lesson_29_object_1.Point
        public override string ToString() // default return class name
        {
            return X.ToString();
        }

        public Point Clone()
        {
            // non deep copying
            // valuable type create copy
            // refrence type same object
            return MemberwiseClone() as Point;
        }

        public new Type GetType()
        {
            return typeof(UInt16);
        }
    }
}