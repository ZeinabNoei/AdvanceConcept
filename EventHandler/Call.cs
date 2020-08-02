using System;

namespace EventHandler
{
    //public delegate void handler(int value);

    public class Call
    {
        public event Handler UpdateCaller;

        public void UpdateCalling(int value)
        {
            if (this.UpdateCaller != null)
            {
                UpdateCaller(value);
            }
        }

        public static void show(int value)
        {
            Console.WriteLine(string.Format("number is ", value));
        }

    }
}
