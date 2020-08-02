using System;

namespace ImplicitvsExplicitImplementation
{
    class Parent
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base - Method1");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Base - Method2");
        }
        public void Method3()
        {
            Console.WriteLine("Base - Method3");
        }
    }
}
