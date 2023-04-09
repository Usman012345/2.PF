using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Enter a number:");
            x=int.Parse(Console.ReadLine());
            while(x!=-1)
            {
                Console.WriteLine("Enter a number:");
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
