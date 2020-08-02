using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Linq

            // Select * From Person as p
            // From p in Person Select p 

            int[] numbers = { 1, 3, 5, 7, 9, 10, 15, 19, 20, 25, 34, 46, 50, 60, 70, 80, 100 };

            int[] result1 = (from n in numbers select n).ToArray();

            int[] result2 = (from n in numbers
                             orderby n descending
                             select n).ToArray();

            int[] result3 = (from n in numbers
                             where n > 30 && n < 80
                             orderby n descending
                             select n).ToArray();

            int result4 = (from n in numbers
                           where n == 3
                           select n).First();

            int result5 = (from n in numbers
                           where n == 2
                           select n).FirstOrDefault();

            int result6 = (from n in numbers
                           where n == 3
                           select n).Single();

            int result7 = (from n in numbers
                           where n == 2
                           select n).SingleOrDefault();

            var i1 = 123;
            var i2 = "Iman Madaeny";
            var i3 = DateTime.Now;
            //i1 = "Iman";

            bool result8 = (from n in numbers
                            where n == 2
                            select n).Any();

            int Count = (from n in numbers
                         select n).Count();
            int Max = (from n in numbers
                       select n).Max();
            int Min = (from n in numbers
                       select n).Min();

            int Sum = (from n in numbers
                       select n).Sum();

            List<string> Names = new List<string>();
            Names.Add("Iman");
            Names.Add("Ali");
            Names.Add("Sara");
            Names.Add("Mohammad");
            Names.Add("Mina");

            var res1 = (from n in Names
                        select n).ToList();

            var res2 = (from n in Names
                        where n.ToLower().Contains("i")
                        select n).ToList();

            var res3 = (from n in Names
                        where n.ToLower().StartsWith("i")
                        select n).ToList();

            var res4 = (from n in Names
                        where n.ToLower().EndsWith("i")
                        select n).ToList();
        }
    }
}
