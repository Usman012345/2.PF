using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0,area;
            Console.WriteLine("Enter the side of square: ");
            x=int.Parse(Console.ReadLine());
            area = x * x;
            Console.WriteLine(area);
            Console.Read();
        }
    }
}
