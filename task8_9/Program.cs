using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 3;
            int option;
            Console.WriteLine("1.Sign up");
            Console.WriteLine("2.Sign in");
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                signup(ref count);
            }
            else
                signin(ref count);
        }
        static void signin(ref int count)
        {
            string Username_, password_;
            Console.WriteLine("enter your Username: ");
            Username_ = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            password_ = Console.ReadLine();
           bool exists= readfile(Username_,password_,count);
            if (exists == true)
            {
                Console.WriteLine("Signed in..");
            }
            else
                Console.WriteLine("Invalid input..");
            Console.Read();
        }
        static void signup(ref int count)
        {
            string Username, password;
            Console.WriteLine("enter your Username: ");
            Username = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            password = Console.ReadLine();
            count++;
            storedata(Username, password);
            Console.WriteLine("Proceding to sign in menu:..");
            Thread.Sleep(200);
            signin(ref count);
        }
        static void storedata(string Username, string password)
        {
            File.Exists("E:\\PF\\PFlab1\\task8 & 9\\Data.txt");
            StreamWriter data = new StreamWriter("E:\\PF\\PFlab1\\task8 & 9\\Data.txt", true);
            //data.WriteLine(Username + ","+ password);
            data.WriteLine("{0},{1}",Username,password);
            data.Flush();
            data.Close();
        }
        static bool readfile(string username_, string password_,int count)
        {
            string username = "",password = "";
            bool run=false,comma=false;

            string line;
            int x = 0;
            char comma_ = ',';
            if (File.Exists("E:\\PF\\PFlab1\\task8 & 9\\Data.txt"))
            {
                StreamReader data = new StreamReader("E:\\PF\\PFlab1\\task8 & 9\\Data.txt", true);


                //data.WriteLine(Username + ","+ password);
                // int runned = 0;
                for (int y = 0; y < count; y++)
                {
                    comma = false;
                    x = 0;
                    run = false;
                    username = null;
                    password = null;
                    // runned++;
                    
                    //Console.WriteLine("Running");
                    line = data.ReadLine();
                    string[] line1= line.Split(comma_);
                    username = line1[0];
                    password = line1[1];
                    /*for (int c = 0; c < line.Length; c++)
                    {
                        if (line[x] != ',' && comma == false)
                        {
                            username = username + line[x];
                        }
                        else
                        {
                            comma = true;
                            if(run==false)
                            {
                                x++;
                                c++;
                                run = true;
                            }
                        }
                        if (comma == true)
                        {
                            password = password + line[x];
                        }
                        if (x < line.Length - 1)
                        {
                            x++;
                        }
                    }
*/
                    if (username_ == username && password_ == password)
                        {
                        //Console.WriteLine("askdjfhjdhv");
                            return true;
                        }
                    
                }
                data.Close();
            }
                
            return false;
        }
    }
}
