namespace lesson_13_interface
{
    public class BmwSeven : ICar
    {
        public int Move(int distance)
        {
            return distance / 100;
        }
    }
}