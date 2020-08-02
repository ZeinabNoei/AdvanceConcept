using System;

namespace ImplicitvsExplicitImplementation
{
    class Child : Parent
    {
        public override void Method1()
        {
            Console.WriteLine("Derived - Method1");
        }

        //public override void Method2()
        //{
        //    Console.WriteLine("Derived - Method2");
        //}
        public new void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }
        //public void Method3()
        //{
        //    //base.Method3();
        //    Console.WriteLine("Derived - Method3");
        //}
    }
}
