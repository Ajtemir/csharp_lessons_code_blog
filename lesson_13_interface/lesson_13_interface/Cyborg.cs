using System;

namespace lesson_13_interface
{
    public class Cyborg : ICar, IPerson
    {
        int ICar.Move(int distance)
        {
            return distance / 100;
        }

        int IPerson.Move(int distance)
        {
            return distance / 5;
        }
        
        
    }
}