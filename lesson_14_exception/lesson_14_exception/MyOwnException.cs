using System;

namespace lesson_14_exception
{
    class MyOwnException : Exception
    {
        public MyOwnException() : base("Это моё исключение")
        {
            
        }

        public MyOwnException(string message) : base(message)
        {
            
        }

    }
}