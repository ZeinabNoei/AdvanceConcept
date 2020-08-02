using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////
            /// 
            /// <summary>
            /// Important
            /// </summary>           
            List<int> list = new List<int> { 1, 2, 3, 4 };
            Predicate<int> predicate = new Predicate<int>(GreaterThanTow);
            List<int> newList = list.FindAll(predicate);
            Console.ReadKey();

        /// <summary>
        /// ////////////////////
        /// </summary>



        List<Employee> employ = Employee.ListEmployees();
            employ.ForEach(x => x.Baz = x.Age > 30);
            employ.ForEach(x => Console.WriteLine(string.Format("fname is :{0} and Lname is :{1} and age is :{2} and baz is :{3}", x.FName, x.LName, x.Age, x.Baz)));
            Console.ReadKey();



            //Employees.ForEach(x =>
            //{

            //    if (x.Age > 40)
            //        x.Baz = true;
            //    else
            //        x.Baz = false;

            //});
            //foreach (Employee employee in Employees)
            //{
            //    Console.WriteLine(string.Format("name is {0} and fname is {1} and age : {2} baz:{3}", employee.FName, employee.LName, employee.Age, employee.Baz));
            //}

            ///////////////////////////////////
            ///  
            List<Person> People = Person.GetPerson();

            People.ForEach(x =>
            {
                if (x.Age > 30)
                    Console.WriteLine($"Person {x.FistName} Is Settelmented.");
                else
                    Console.WriteLine($"Person {x.FistName} Is Not Settelented.");
            }
               );


            Console.ReadKey();


            foreach (Person emp in People)
            {
                if (emp.FistName == "Roya")
                    Console.WriteLine($"Person {emp.FistName} Is Employed.");
                else
                    Console.WriteLine($"Person {emp.FistName} Is Not Employed.");
            };
            Console.ReadKey();

        
        }
        //////////////////////////
        ///   
        static bool GreaterThanTow(int arg)
        {
            return arg > 2;
        }
    }
}
