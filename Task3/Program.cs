using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks;
            Console.WriteLine("Enter your marks: ");
            marks = int.Parse(Console.ReadLine());
            if (marks < 50)
                Console.WriteLine("fail");
            else
                Console.WriteLine("pass");
            Console.Read();
        }
    }
}
