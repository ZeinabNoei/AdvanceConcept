using System;
using System.Collections.Generic;

namespace AspectsofGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(44); // boxing
            int il = list[0];   // Unboxing
            foreach (int i2 in list)
            {
                Console.WriteLine(i2);
            }
            Console.ReadKey();
        }
    }
}
