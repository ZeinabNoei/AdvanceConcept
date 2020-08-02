using System;

namespace Switch_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number :");
            int numberOfWeek = Convert.ToInt32(Console.ReadLine());


            switch (numberOfWeek)
            {
                case 1:
                    {
                        Console.WriteLine("It Is Shanbe ...");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("It Is 1Shanbe ...");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("It Is 2Shanbe ...");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("It Is 3Shanbe ...");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("It Is 4Shanbe ...");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("It Is 5Shanbe ...");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Fitile Jome Tatile ...");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Not Found ...");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
