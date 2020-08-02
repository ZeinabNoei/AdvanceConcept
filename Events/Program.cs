using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var dealer = new CarDealer();

            var michael = new Consumer("Michael");
            //dealer.NewCarInfo += michael.NewCarIsHere;
            //WeakCarInfoEventManager.AddListener(dealer,michael);
            //WeakEventManager<CarDealer, CarInfoEventArgs>.AddHandler(dealer, "CarInfo");
            dealer.NewCar("Mercedes");

            var nick = new Consumer("Nick");
            //dealer.NewCarInfo += nick.NewCarIsHere;
            WeakCarInfoEventManager.AddListener(dealer, nick);


            dealer.NewCar("Ferrari");

            dealer.NewCarInfo -= michael.NewCarIsHere;
            //dealer.NewCarInfo -= michael.NewCarIsHere;

            WeakCarInfoEventManager.RemoveListener(dealer, michael);

            dealer.NewCar("Toyota");

            Console.ReadLine();

            //int age;
            //int ages = new int();
        }
    }
}
