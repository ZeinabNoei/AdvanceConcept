using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler
{
    public delegate void handler(int value);

    class Program
    {
        static void Main(string[] args)
        {//Publisher publisher = new Publisher();
            //publisher.UpdateStatusHandler += ShowStatus;
            //publisher.DoAJob();
            //Console.ReadLine();

            Console.WriteLine("Please Enter Number:");
            int Number = Convert.ToInt32(Console.ReadLine());

            Call ca = new Call();
            ca.UpdateCaller += Call.show;
            ca.UpdateCalling(Number);

            Console.ReadLine();

            ///

            int UserAction;
            int seq;
            string name;
            int age;

            getUserAction();

            if (UserAction == 1)
            {
                getInfoToAdd();
                Person.AddPerson(seq, name, age);

                clearForm();
                getUserAction();
            }

            else if (UserAction == 2)
            {
                getInfoToRemove();
                Person.RemovePerson(seq);

                clearForm();
                getUserAction();
            }
            else
            {
                Console.WriteLine("Program Terminated.");
                Console.ReadKey();
            }

            void clearForm()
            {
                Console.Clear();
            }

            void getUserAction()
            {
                Console.WriteLine("Plaese Enter 1 To Add Or 2 To Remove Or 0 To Exit :");
                UserAction = Convert.ToInt32(Console.ReadLine());

            }

            void getInfoToAdd()
            {
                seq = 0;
                name = "";
                age = 0;

                Console.WriteLine("Please Enter Seq:");
                seq = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter Name:");
                name = Console.ReadLine();

                Console.WriteLine("Please Enter Age:");
                age = Convert.ToInt32(Console.ReadLine());

            }


            void getInfoToRemove()
            {

                Console.WriteLine("Please Enter Seq To Remove :");
                seq = Convert.ToInt32(Console.ReadLine());
            }


            //foreach (var item in Person.People)
            //{
            //    Console.WriteLine(string.Format("{0}:,{1}:,{2}:", seq, name, age));
            //}
        }

        static void ShowStatus(int value)
        {
            Console.WriteLine(string.Format("Progress {0}...", value));
        }
        
    }
}
