using System;

namespace GenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 6;
            Swap<int>(ref  x, ref  y);
        }
      static void Swap<T>(ref T x, ref T y )
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine(temp);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
