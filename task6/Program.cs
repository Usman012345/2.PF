using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            Console.WriteLine("Enter 3 numbers:");
            for(int x=0; x<3;x++)
            {
                num[x]=int.Parse(Console.ReadLine());
            }
            if (num[0] > num[1] && num[1] > num[2])
                Console.WriteLine(num[0]);
            if (num[1] > num[0] && num[1] > num[2])
                Console.WriteLine(num[1]);
            else
                Console.WriteLine(num[2]);
            Console.Read();

        }
    }
}
