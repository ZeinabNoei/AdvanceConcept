using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate
{
    public class Employee
    {
        public string FName { get; set; }

        public string LName { get; set; }
        public int Age { get; set; }
        public bool Baz { get; set; }


        public static List<Employee> ListEmployees()
        {

            //Employee p1 = new Employee();
            //p1.FName = "Ali";
            //p1.LName = "Noei";
            //p1.Age = 20;
            //p1.Baz = false;
            //Employee p2= new Employee();
            //p2.FName = "Zahra";
            //p2.LName = "Rahi";
            //p2.Age = 30;
            //p2.Baz = false;
            //List<Employee> listemploy = new List<Employee>();
            //listemploy.Add(p1);
            //listemploy.Add(p2);

            //List<Employee> listemploys = new List<Employee>() { p1, p2 };

            //List<Employee> listemployes = new List<Employee>() {

            //    new Employee (){FName ="ali",LName ="nal",Age=13,Baz =true }

            //};

            return new List<Employee> {
                new Employee ()
                {
                    FName ="Ali",
                    LName ="noei",
                    Age =32
                },
                new Employee (){
                FName ="sara",
                LName ="noei",
                Age =23
                },
                new Employee ()
                {
                    FName ="reza",
                    LName ="rezaeei",
                    Age =36
                },
                new Employee ()
                {
                    FName ="vahid",
                    LName ="laleei",
                    Age =38
                },
            };
        }
    }
}
