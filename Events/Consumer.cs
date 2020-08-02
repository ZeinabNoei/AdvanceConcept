using System;
using System.Windows;

namespace Events
{
    public class Consumer : IWeakEventListener
    {
        private string name;
        public Consumer(string name)
        {
            this.name = name;
        }
        public void NewCarIsHere(object sender, CarInfoEventArgs e)
        {
            Console.WriteLine("{0}: car {1} is new.", this.name, e.Car);
        }
        public bool ReceiveWeakEvent(Type managerType, object sender, EventArgs e)
        {
            NewCarIsHere(sender, e as CarInfoEventArgs);
            return true;
        }
    }
}
