using System;

namespace Delegate
{
    public delegate int AddMethodDelegate(int a);
    class Delegate
    {
        public void UseDelegate(AddMethodDelegate addmethod)
        {
            Console.WriteLine(addmethod(5));
        }
    }
    public class Helper
    {
        public int CustomAdd(int a)
        {
            return ++a;
        }
    }
    public class person
    {
        public int plus(int b)
        {
            return b + 10;
        }
    }
}
