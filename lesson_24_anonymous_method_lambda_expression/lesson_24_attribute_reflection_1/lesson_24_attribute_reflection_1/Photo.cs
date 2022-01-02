namespace lesson_24_attribute_reflection_1
{
    [Geo(10, 20)]
    public class Photo
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public Photo(string name)
        {
            Name = name;
        }
        
    }
}