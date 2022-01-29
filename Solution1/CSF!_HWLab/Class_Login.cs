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

            Console.WriteLine("What's your username: ");
            string username = Console.ReadLine().ToLower();

            if (username == "correct username")
            {
                Console.WriteLine("Correct username!");
            }
            else if (username != "correct username")
            {
                Console.WriteLine("That is the wrong username!");
            }

            Convert.ToInt16(username);
            Console.WriteLine("Enter your username again");

            //For loop here?
            //Put the whole thing in a DoWhile loop?


        }
    }
}
