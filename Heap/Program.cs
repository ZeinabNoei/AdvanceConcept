using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public MyInt AddFive(int pValue)
        {
            MyInt result = new MyInt();
            result.MyValue = pValue + 5;
            return result;
        }
    }
     class MyInt
    {
        public int MyValue;
    }

}
