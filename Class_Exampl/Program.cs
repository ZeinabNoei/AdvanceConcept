using System;

namespace Class_Exampl
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = MyClass.Sum(4, 5);
            Console.WriteLine(sum);
            Console.WriteLine(MyClass.FullName("Iman", "Madaeny"));
            // Console.ReadKey();

            Car car1 = new Car();
            car1.CarName = "Pride";
            car1.CarSpeed = 100;
            car1.Carmodel = "1400";

            Car car2 = new Car();
            car2.CarName = "Peykan";
            car2.CarSpeed = 220;
            car2.Carmodel = "1388";

            Console.WriteLine(car1.CarName + " " + car1.CarSpeed + " " + car1.Carmodel);
            Console.WriteLine(car2.CarName + " " + car2.CarSpeed + " " + car2.Carmodel);


            Person p1 = new Person("Iman", "Madaeny", "TopLear.Com");
            Person p2 = new Person("Ali", "Rezaei", "Barnamenevisan.org");

            Console.WriteLine($"Name : {p1.name} Family : {p1.family} WebSite : {p1.website}");
            Console.WriteLine($"Name : {p2.name} Family : {p2.family} WebSite : {p2.website}");

            Console.WriteLine("********************************************");
            Console.WriteLine("Please Enter Personal Number :");
            int number = Convert.ToInt32(Console.ReadLine());
            Person[] people = new Person[number];

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Please Enter Person[{(i + 1)}] Name :");
                string name = Console.ReadLine();

                Console.WriteLine($"Please Enter Person[{(i + 1)}] Family :");
                string family = Console.ReadLine();

                Console.WriteLine($"Please Enter Person[{(i + 1)}] Web Site :");
                string website = Console.ReadLine();

                Person p = new Person(name, family, website);
                people[i] = p;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Person person in people)
            {
                Console.WriteLine($"Name : {person.name} Family : {person.family} WebSite : {person.website}");
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
