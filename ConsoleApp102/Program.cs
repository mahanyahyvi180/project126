using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp102
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for (int counter = 2; counter <= 20; counter += 2)
            {
                total += counter;
            }
            Console.WriteLine($"sum is{total}");
            Console.ReadLine();
        }
    }
}
