using System;

namespace lesson_15_delegate_event
{
    public class Person
    {
        public event Action GoToSleep;
        public event EventHandler DoWork;

        public void TakeTime(DateTime now)
        {
            if (now.Hour <= 8)
            {
                GoToSleep?.Invoke();
            }
            else
            {
                var args = new EventArgs();
                DoWork?.Invoke(this, null);
            }
        }
    }
}