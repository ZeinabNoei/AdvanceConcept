using System;

namespace Convert_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            string test = Convert.ToString(a);


            string num1 = "22";

            int num = Convert.ToInt32(num1);

            // num = num + 22;
            // num++;
            // num--;
            num += 3;
            bool IsActive = Convert.ToBoolean("True");

            Console.WriteLine(test);
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
