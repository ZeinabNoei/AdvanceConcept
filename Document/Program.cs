using System;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            var dm = new DocumentManager<Document>();
            dm.AddtDocumnet(new Document("Content1", "Tilte1"));
            dm.AddtDocumnet(new Document("Content2", "Tilte2"));
            foreach (string item in dm.GetTitles())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

}
