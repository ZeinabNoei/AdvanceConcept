using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler
{
    public class Person
    {
        public delegate void HandlerOnAdd();
        public delegate void HandlerOnRemover();


        public int Seq { get; set; }
        public string FName { get; set; }
        public int Age { get; set; }

        public static List<Person> People = new List<Person>();

        public static void AddPerson(int seq, string fName, int age)
        {

            Person prsn = new Person();
            prsn.Seq = seq;
            prsn.FName = fName;
            prsn.Age = age;
            People.Add(prsn);

        }

        public static void RemovePerson(int seq)
        {
            var item = People.SingleOrDefault(x => x.Seq == seq);
            People.Remove(item);

        }

        public static void ListAllPerson()
        {
            foreach (Person prsn in People)
            {
                Console.WriteLine(string.Format("Seq = {0},  Name = {1},  Age = {2}", prsn.Seq, prsn.FName, prsn.Age));
            }

        }
    }
}
