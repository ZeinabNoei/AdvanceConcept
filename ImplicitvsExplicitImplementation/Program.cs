using System;

namespace ImplicitvsExplicitImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Widget w = new Widget();
            w.Foo();
            ((I1)w).Foo();
            ((I2)w).Foo(); //Error
     
            ClassBase Parent = new ClassBase();
            ClassDrived Child = new ClassDrived();
            ClassBase castClass = new ClassDrived();

            Console.WriteLine(Parent.Method1());
            Console.WriteLine(Child.Method1());

            Console.WriteLine(Child.Method());

            Console.WriteLine(castClass.Method());
            Console.WriteLine(castClass.Method1());

            Console.ReadKey();

            ClassDrived C = new ClassDrived();
            ClassBase B = new ClassDrived();

            Console.WriteLine(C.Method());
            Console.WriteLine(B.Method());
            Console.ReadKey();
           

            Parent p = new Parent();
            Child c = new Child();
            Parent pc = new Child();

            p.Method1();
            p.Method2();
            c.Method3();

            c.Method1();
            c.Method2();
            c.Method3();

            if (pc is Parent)
            {
                pc.Method1();
                pc.Method2();
                pc.Method3();
            }

            Parent pp = (Parent)c;
            if (pp is Parent)
            {
                pp.Method1();
                pp.Method2();
                pp.Method3();
            }
            if (pp is Child)
            {
                pp.Method1();
                pp.Method2();
                pp.Method3();
            }

            Console.ReadKey();
            
        }
    }
 
  

   
}
