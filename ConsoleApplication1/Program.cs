using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var client = new ServiceReference1.Service1Client())
            {
                client.DoWork();
            }
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
