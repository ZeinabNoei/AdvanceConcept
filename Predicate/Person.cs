using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate
{
    public class Person
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsSettelment { get; set; }

        public static List<Person> GetPerson()
        {

            Person Emp1 = new Person();
            Person Emp2 = new Person();
            Person Emp3 = new Person();

            Emp1.FistName = "Fariba";
            Emp1.LastName = "Noie";
            Emp1.Age = 20;
            Emp1.IsSettelment = false;

            Emp2.FistName = "Roya";
            Emp2.LastName = "Arian";
            Emp2.Age = 42;
            Emp2.IsSettelment = true;

            Emp3.FistName = "Negar";
            Emp3.LastName = "Sarparast";
            Emp3.Age = 30;
            Emp3.IsSettelment = false;

            //List<Person> People = new List<Person>() {Emp1, Emp2  } ;
            List<Person> People = new List<Person>();

            People.Add(Emp1);
            People.Add(Emp2);
            People.Add(Emp3);

            //Console.ReadKey();
            //return new List<Person> { new Person() { FistName = "Fariba", LastName = "Noie", Age = 20, IsSettelment = false } };
            return People;

        }

    }
}
