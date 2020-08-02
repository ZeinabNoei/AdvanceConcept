using System;

namespace ImplicitvsExplicitImplementation
{
    public class Widget : I1
    {
        public void Foo()
        {
            Console.WriteLine("Widget is Implementation of I1.Foo");
        }
        //int I2.Foo()
        //{
        //    Console.WriteLine("Widget is Implementation of I2.Foo");
        //    return 42;

        //}
    }
}
