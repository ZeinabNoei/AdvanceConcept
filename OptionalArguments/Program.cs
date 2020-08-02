using System;
namespace OptionalArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMethod(5);
        }
        static void TestMethod(int notOptionalNumber, int optionalNumber = 10)
        {
           Console.Write(notOptionalNumber + optionalNumber);
            Console.ReadKey();
        }
    }
}
