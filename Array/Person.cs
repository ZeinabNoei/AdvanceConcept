using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Person : IComparable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("{0} {1}", FirstName, LastName);
        }
        public int CompareTo(Person other)
        {
            if (other == null) throw new ArgumentNullException("other");
            int result = this.LastName.CompareTo(other.LastName);
            if (result == 0)
            {
                result = this.FirstName.CompareTo(other.FirstName);
            }
            return result;
        }
    }
}
