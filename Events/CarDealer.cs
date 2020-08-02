using System;

namespace Events
{
    public class CarDealer
    {
        public event EventHandler<CarInfoEventArgs> NewCarInfo;
        public void NewCar(string car)
        {
            Console.WriteLine("Car Dealer, New Car {0}", car);
            NewCarInfo?.Invoke(this, new CarInfoEventArgs(car));
            //EventHandler<CarInfoEventArgs> handler = NewCarInfo;
            //if (handler != null)
            //{
            //    handler(this, new CarInfoEventArgs(car));
            //}
        }
    }
}
