using System;
using System.Data.SqlClient;


namespace Exeption_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            try
            {
                Console.WriteLine("Please Enter Numer 1 :");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Number 2:");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter Just Number ...");
                Console.ResetColor();
            }
            //catch (SqlException)
            //{
            //    Console.WriteLine("SqlException");
            //}
            catch
            {
                Console.WriteLine("Salam");
            }
            finally
            {
                Console.WriteLine("Finally");
            }

            Console.WriteLine("Sum Is : " + (num1 + num2));
            Console.ReadKey();
        }
    }
}
