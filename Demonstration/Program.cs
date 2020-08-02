using System;

namespace Demonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            Thing x = new Animal();
            Switch(ref x);
            Console.WriteLine("x is Animal : " + (x is Animal).ToString());
            Console.WriteLine("x is Vegetable : " + (x is Vegetable).ToString());
        }    
        public static void Switch(ref Thing pValue)
        {
            pValue = new Vegetable();
        }
    }
}
