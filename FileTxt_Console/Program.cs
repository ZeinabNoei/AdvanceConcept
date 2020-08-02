using System;

namespace FileTxt_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassTxt txt = new ClassTxt();
            Console.WriteLine("Please Enter FileName:");
            string path = @"D:\" + Console.ReadLine() + ".txt";

            Console.WriteLine("Please inter content...");
            string content = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Are You Save Content?Yes/No");
            string str = Console.ReadLine();

            txt.Path = path;
            txt.txtsile(content, str);
            txt.ShowFile(path);

            Console.ReadKey();

        }
    }
}
