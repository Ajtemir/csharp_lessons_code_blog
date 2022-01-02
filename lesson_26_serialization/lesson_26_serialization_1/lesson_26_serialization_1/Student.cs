using System;

namespace lesson_26_serialization_1
{
    [Serializable]
    public class Student
    {
        
        public string Name { get; set; }
        public int Age { get; set; }

        public Group Group { get; set; }
        
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}