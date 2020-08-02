using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingReferencetoOriginal_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct x = new MyStruct();
            DoSomethingRef(ref x);
            DoSomethingValue(x);
        }
        public static void DoSomethingRef(ref MyStruct pValue)
        {
            // DO SOMETHING HERE....
        }
        public static void DoSomethingValue(MyStruct pValue)
        {
            // DO SOMETHING HERE....
        }
    }
    public struct MyStruct
    {
        long a, b, c, d, e, f, g, h, i, j, k, l, m;
    }
}

