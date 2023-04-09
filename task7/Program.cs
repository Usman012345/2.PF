using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter two numbers:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            int sum = addition(x, y);
            Console.WriteLine("The sum is {0}", sum);
            Console.Read();
        }
        static int addition(int x,int y)
        {
            int sum = x + y;
            return sum;
        }
    }
}
