using System;

namespace Property_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Car pride = new Car();
            pride.Speed = 120;
            //pride.CarName = "Peykan";
            Console.WriteLine($"Car Name Is : {pride.CarName}");
            Console.WriteLine($"Speed Is {pride.Speed}");

            Console.ReadKey();
        }
    }
}
