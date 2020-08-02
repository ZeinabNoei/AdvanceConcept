using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>();
            Person p1 = new Person();
            p1.PersonId = 1;
            p1.Name = "Iman";
            p1.Family = "Madaeny";
            p1.Age = 30;
            People.Add(p1);

            Person p2 = new Person()
            {
                PersonId = 2,
                Name = "Ali",
                Family = "rezaei",
                Age = 19
            }
                ;
            People.Add(p2);

            People.Add(new Person() { PersonId = 2, Name = "zahra", Family = "tabi", Age = 13 });

            var result = People.ToList();
            var result1 = People.OrderByDescending(p => p.Age).ToList();
            var result3 = People.Where(p => p.Name.ToLower() == "iman").ToList();

            var result4 = People.Where(p => p.Age > 25 && p.Age < 40).ToList();

            var result5 = People.Select(p => p.Name).ToList();
            var result6 = People.Select(p => new { p.Name, p.Family }).ToList();

            foreach (Person p in result)
            {
                Console.WriteLine($"Id:{p.PersonId } Name :{p.Name } Family:{p.Family }  age:{p.Age }");
            }
            List<PersonCar> cars = new List<PersonCar>() {
                new PersonCar() {PersonId=1, CarName ="Pride" , CarModel="1380"},
                new PersonCar (){ PersonId =3,CarName ="Peykan",CarModel="1390"}
            };
            var join = (from p in People
                        join c in cars
                        on p1.PersonId equals c.PersonId
                        select new
                        {
                            p.PersonId,
                            p.Name,
                            p.Family,
                            p.Age,
                            c.CarName,
                            c.CarModel
                        }
                        ).ToList();

            int[] numbers = { 1, 1, 2, 3, 4, 9, 10, 15, 20, 25 };
            var res1 = numbers.Distinct().ToList();

            var res2 = numbers.OrderByDescending(n => n).Take(3).ToArray();
            var res3 = numbers.OrderByDescending(n => n).Skip(3).ToArray();
            Console.ReadKey();

        }
    }
    class PersonCar
    {
        public int PersonId { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }

    }
    class Person
    {
        public int PersonId { get; set; }

        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }

    }
}
