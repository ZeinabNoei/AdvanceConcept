using System;

namespace Delegate
{
    delegate double DoubleOp(double x);
    delegate int sum(int x, int y);
    class Program
    {
        public delegate void Print(int a);
        static void Main(string[] args)
        {
            Helper helper = new Helper();
            AddMethodDelegate addmethod = new AddMethodDelegate(helper.CustomAdd);
            new Delegate().UseDelegate(addmethod);

            person per = new person();
            AddMethodDelegate pers = new AddMethodDelegate(per.plus);

            new Delegate().UseDelegate(pers);


            new Delegate().UseDelegate(delegate (int a)
            {
                return helper.CustomAdd(a);
            }
            );

            new Delegate().UseDelegate(a => helper.CustomAdd(a));


            Console.ReadKey();

            ////MathOperations

            DoubleOp[] operations =
                    {

                MathOperations.MultiplyByTwo,
                MathOperations.Square
            };
            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine("Using operations[{0}]:" ,1);
                ProcessAndDisplayNumber(operations[i], 2.0);
                ProcessAndDisplayNumber(operations[i], 7.94);
                ProcessAndDisplayNumber(operations[i], 1.414);
                Console.WriteLine();
            }

            //Delegate Example Old 
            Print printDel = PrintNumber;
            printDel(1000);
            printDel(500);

            printDel = PrintMoney;
            printDel(1000);
            printDel(200);

            Console.ReadKey();
        }
        static void ProcessAndDisplayNumber(DoubleOp action, double value)
        {
            double result = action(value);
            Console.WriteLine("Value is {0}, result of operation is {1} " , value ,result );
        }


        /// <summary>
        /// /////////////////////////////////////
        /// </summary>
        /// <param name="num"></param>

              public static void PrintNumber(int num)
        {
            Console.WriteLine("Number :{0, -12:N0}", num);
        }

        public static void PrintMoney(int Money)
        {
            Console.WriteLine("Money :{0:c}", Money);
        }

        Type t = typeof(double);
        int i = add(2, 3);

        public static int add(int x, int y)
        {
            return x + y;
        }

    }

        

}
