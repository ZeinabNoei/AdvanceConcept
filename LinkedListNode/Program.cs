using System;

namespace LinkedListNode
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new LinkedfList();
            list1.AddLast(2);
            list1.AddLast(4);
            list1.AddLast("6");
            foreach (var i in list1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            var list2 = new LinkedList<int>();
            list2.AddLast(1);
            list2.AddLast(3);
            list2.AddLast(5);
            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
            var list3 = new LinkedList<string>();
            list3.AddLast("2");
            list3.AddLast("four");
            list3.AddLast("foo");

            foreach (string s in list3)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
