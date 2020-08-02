using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Person : IComparable
    {
        public int CompareTo(object obj)
        {
            Person other = obj as Person;
            //return this.LastName.Compareto(other.LastName);
            throw new NotImplementedException();

        }
    }
    public class Persons : IComparable<Person>
    {
        public int CompareTo(Person other)
        {
           throw new NotImplementedException();
            //return this.LastName.Compareto(other.LastName);

        }
    }

}
