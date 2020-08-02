using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            UseParamsint(1,2,4);            
            int[] myInArray = { 5, 6, 7, 8, 9 };
            UseParamsint(myInArray);

            UseParamsobject(9, 'a', "test");
            object[] myobjArray = { 2, 'b', "txt", "set" };
            UseParamsobject(myobjArray);
        }
        public static void UseParamsint(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
        public static void UseParamsobject(params object[] list)
        {
            for (int j = 0; j < list.Length; j++)
            {
                Console.WriteLine(list[j]);
            }
            Console.ReadKey();
        }

    }
}
