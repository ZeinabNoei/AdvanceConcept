using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct x = new MyStruct();
            DoSomething(x);
        }

    public static void DoSomething(MyStruct pValue)
    {
        // DO SOMETHING HERE....
    }

    }
    public struct MyStruct
    {
        long a, b, c, d, e, f, g, h, i, j, k, l, m;
    }

}
