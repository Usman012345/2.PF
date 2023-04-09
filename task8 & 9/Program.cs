using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;        
            Console.WriteLine("1.Sign up");
            Console.WriteLine("2.Sign in");
            option=int.Parse(Console.ReadLine());
            if (option == 1)
            {
                signup();
            }
            /*else
                signin();*/
        }
        static void signup()
        {
            string Username, password;
            Console.WriteLine("enter your Username: ");
            Username = Console.ReadLine(); 
            Console.WriteLine("Enter your password: ");
            password = Console.ReadLine();
            storedata(Username, password);
        }
        static void storedata(string Username,string password)
        {
            File.Exists("E:\\PF\\PFlab1\\task8 & 9\\Data.txt");
            StreamWriter data = new StreamWriter("E:\\PF\\PFlab1\\task8 & 9\\Data.txt",true);
            data.WriteLine(Username,password);
            data.Flush();
        }
    }
}
