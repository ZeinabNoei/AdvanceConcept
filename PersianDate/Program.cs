using System;
using System.Globalization;

namespace PersianDate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            PersianCalendar persian = new PersianCalendar();
            string persianDate = persian.GetYear(DateTime.Now) + "/" + persian.GetMonth(DateTime.Now) + "/" + persian.GetDayOfMonth(DateTime.Now);
            Console.WriteLine(persianDate);
        }
    }
}
