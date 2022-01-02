using System;

namespace lesson_24_method_lambda_2
{
    public class Lesson
    {
        public string Name { get; }
        public DateTime Begin { get; private set; }

        public event EventHandler<DateTime> Started; 

        public Lesson(string name)
        {
            Name = name;
        }

        public void Start()
        {
            Begin = DateTime.Now;
            Started?.Invoke(this, Begin);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}