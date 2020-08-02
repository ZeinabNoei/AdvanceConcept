using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {      
        }
        public void Go()
        {
            MyInt x = new MyInt();
            x.MyValue = 2;
            DoSomething(x);
            Console.WriteLine(x.MyValue.ToString());
        }
        public void DoSomething(MyInt pValue)
        {
            pValue.MyValue = 12345;
        }
    }
    public class MyInt
    {
        public int MyValue;
    }
  
}
