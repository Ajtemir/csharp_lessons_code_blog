namespace lesson_24_attribute_reflection_1
{
    public class GeoAttribute : System.Attribute
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public GeoAttribute(){}

        public GeoAttribute(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"[{X};{Y}]";
        }
    }
}