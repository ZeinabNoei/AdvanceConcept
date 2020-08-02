using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingValueType
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Class1
    {
        public void Go()
        {
            int x = 5;
            AddFive(x);
            Console.WriteLine(x.ToString());
        }
        public int AddFive(int pValue)
        {
            pValue += 5;
            return pValue;
        }


    }
}
