using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF__HWLab
{
    class Class_Login
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class: Login");

            bool correctUser = false;


            Console.WriteLine("What's your username: ");
            string username = Console.ReadLine().ToLower();


            do
            {

                if (username == "correct username" || username == "admin")
                {
                    correctUser = true;
                    Console.WriteLine("Access Granted!");
                }
                else if (username != "correct username")
                {
                    Console.WriteLine("That is the wrong username!\n ACCESS DENIED - you have 2 more tries remaining...");
                    for (int i = 1; i < 3; i++)
                    {
                        Console.WriteLine("Enter your username again");
                        username = Console.ReadLine().ToLower();
                        if (username == "correct username" || username == "admin")
                        {
                            correctUser = true;
                            Console.WriteLine("Access Granted!");
                            break;
                        }
                    }
                    Console.WriteLine("Permission denied. Terminal locked.");//Fix this to not execute if permission is granted
                    break;
                }
                else
                {
                    Console.WriteLine("You are not admin");
                }

                //Convert.ToInt16(username);
                //Console.WriteLine("Enter your username again");

                //For loop here?
                //Put the whole thing in a DoWhile loop?
            } while (!correctUser);

        }
    }
}
