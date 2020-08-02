using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using System.Text;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {

            Action<string> AnyType = x=> x = "Ali";
            dynamic dyn;
            dyn = 100;
            Console.WriteLine(dyn.GetType());
            Console.WriteLine(dyn);
            Console.WriteLine();

            dyn = "This is a string";
            Console.WriteLine(dyn.GetType());
            Console.WriteLine(dyn);
            Console.WriteLine();

            dynamic d = new Func<int, long>(input => input * input);
            long power = d(10);
            Console.WriteLine(power);
            Console.WriteLine();

            dyn = new Person() { FirstName = "Bugs", LastName = "Bunny" };
            Console.WriteLine(dyn.GetType());
            Console.WriteLine("{0} {1}", dyn.FirstName, dyn.LastName);
            Console.WriteLine();

            dyn = new CustomDynamicObject();
            dyn.FirstName = "Bugs";
            dyn.LastName = "Bunny";
            Console.WriteLine(dyn.GetType());
            Console.WriteLine("{0} {1}", dyn.FirstName, dyn.LastName);
            Console.WriteLine();

            dyn.MiddleName = "Rabbit";
            Console.WriteLine(dyn.MiddleName);
            Console.WriteLine(dyn.GetType());
            Console.WriteLine("{0} {1} {2}", dyn.FirstName, dyn.MiddleName, dyn.LastName);
            List<Person> friends = new List<Person>();
            friends.Add(new Person() { FirstName = "Daffy", LastName = "Duck" });
            friends.Add(new Person() { FirstName = "Porky", LastName = "Pig" });
            friends.Add(new Person() { FirstName = "Tweety", LastName = "Bird" });
            dyn.Friends = friends;
            foreach (Person friend in dyn.Friends)
            {
                Console.WriteLine("{0} {1}", friend.FirstName, friend.LastName);
            }

            Func<DateTime, string> GetTomorrow = today => today.AddDays(1).ToShortDateString();
            dyn.GetTomorrowDate = GetTomorrow;
            Console.WriteLine("Tomorrow is {0}", dyn.GetTomorrowDate(DateTime.Now));

            Console.WriteLine();
            Console.WriteLine("Using ExpandoObject...");
            DoExpando();

            Console.Read();
        }

        static void DoExpando()
        {
            dynamic expObj = new ExpandoObject();
            expObj.FirstName = "Daffy";
            expObj.LastName = "Duck";
            Console.WriteLine(expObj.GetType());
            Console.WriteLine(expObj.FirstName + " " + expObj.LastName);
            Func<DateTime, string> GetTomorrow = today => today.AddDays(1).ToShortDateString();
            expObj.GetTomorrowDate = GetTomorrow;
            Console.WriteLine("Tomorrow is {0}", expObj.GetTomorrowDate(DateTime.Now));

            expObj.Friends = new List<Person>();
            expObj.Friends.Add(new Person() { FirstName = "Bob", LastName = "Jones" });
            expObj.Friends.Add(new Person() { FirstName = "Robert", LastName = "Jones" });
            expObj.Friends.Add(new Person() { FirstName = "Bobby", LastName = "Jones" });

            foreach (Person friend in expObj.Friends)
            {
                Console.WriteLine(friend.FirstName + "  " + friend.LastName);
            }
        }
    }
}
