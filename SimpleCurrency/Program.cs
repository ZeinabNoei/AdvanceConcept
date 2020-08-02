using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCurrency
{
    class Program
    {
        static void Main(string[] args)
        {


            Currency balance = new Currency(10, 50);
            //long amount = (long)balance;
            long amount = balance;
            double amountd = balance;
            //چون ولیو تایپه پس درسته یعنی ادرسش یکیه 
            //امپراتور == برای استراک تعریف نشده 
            MyStruct s1 = new MyStruct();
            s1.x = 10;
            MyStruct s2 = new MyStruct();
            s2.x = 10;
            var Value = s1.GetHashCode() == s2.GetHashCode();
            //Value = s1 == s2;


            int i = 123;
            object o = i + 10;
            i = (int)o;


            try
            {
                Currency balances = new Currency(50, 35);

                Console.WriteLine(balance);
                Console.WriteLine("balance is " + balance);
                Console.WriteLine("balance is (using ToString()) " + balance.ToString());

                float balance2 = balance;

                //هزینه بره 
                uint Test = 350;
                Currency Rez = (Currency)Test;
                //Currency Rez = new Currency(350,0);
                Console.WriteLine("After converting uint to currency = " + Rez.ToString());
                uint x = (uint)Rez;
                Console.WriteLine("After converting currency to uint = " + x);

                //Console.WriteLine("After converting to float, = " + balance2);

                //uint balance3 = (uint) balance;                 
                //Console.WriteLine("Converting to uint gives " + balance3);

                balance = (Currency)balance2;

                Console.WriteLine("After converting back to Currency, = " + balance);
                Console.WriteLine("Now attempt to convert out of range value of " +
                                  "-$50.50 to a Currency:");

                //checked
                //{
                //    balance = (Currency)(-50.50);
                //    Console.WriteLine("Result is " + balance.ToString());
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
