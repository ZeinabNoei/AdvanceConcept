using System;

namespace GenericMethodsSpecialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new MethodOverLoads();
            test.Foo(33);
            test.Foo("abc");
            test.Bar(44);
        }
    }
    public class MethodOverLoads
    {
        public void Foo<T>(T obj)
        {
            Console.WriteLine("",obj.GetType().Name);
        }
        public void Foo(int x)
        {
            Console.WriteLine("Foo(int x)");
        }
        public void Bar<T>(T obj)
        {
            Foo(obj);
        }
    }
}
