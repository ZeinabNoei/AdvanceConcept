using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BestPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var a = "b";
            show(ref a);
            Console.WriteLine(a);
            
            CreateWebHostBuilder(args).Build().Run();
          

        }
        public static string show(ref string a)
        {
             a = "y";
            return a;
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
