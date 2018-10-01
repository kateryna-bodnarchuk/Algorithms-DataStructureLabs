using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number one");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number two");
            int core = int.Parse(Console.ReadLine());
            Console.WriteLine("Product is " + Product(x, core));
            Console.ReadKey();
        }
    }
}
