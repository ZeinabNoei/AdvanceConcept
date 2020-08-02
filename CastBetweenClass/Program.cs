using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastBetweenClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boss B = new Boss();
            //Child C = new Child();
            // اینجا چون از کلاس A  کست کردیم فول نیم رو نمیبینیم 
            //B.Id = 1;
            //B.Name = "Ali";
            //C.Age = 23;
            //C.Id = 5;
            //C.Name = "mosafa";
            //C.FullName = "mggg";
            ////C = (Child)B;
            //B = C;

            //B.fullname
            Boss b = new Child();
            Boss B = new Boss();
            B.Id = 1;
            B.Name = "Ali";

            b.Id = 5;
            b.Name = "mosafa";

        }
    }
    public class Boss
    {

        public int Id { get; set; }
        public string Name { get; set; }

    }
    public class Child : Boss
    {
        public string FullName { get; set; }
        public int Age { get; set; }
    }

}
