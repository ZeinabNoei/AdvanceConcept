using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            string FullName(string firstName, string lastName)
            {
                return firstName + " " + lastName;
            }

         FullName(lastName: "Doe", firstName: "John");
        }

    }
}
