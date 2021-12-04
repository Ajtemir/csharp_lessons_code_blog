using System;

namespace lesson_13_interface
{
    public class LadaSeven : ICar, IDisposable
    {
        public int Move(int distance)
        {
            return distance / 40;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}