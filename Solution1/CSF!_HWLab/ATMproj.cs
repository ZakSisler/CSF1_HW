using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF__HWLab
{
    class ATMproj
    {
        static void Main(string[] args)
        {

            bool repeat = true;

            do
            {

                Console.WriteLine();
                Console.Title = "----ACME ATM CO.----";
                Console.WriteLine("ACME ATM Co.");



                Console.WriteLine("B) Bill\n" +
                    "P) Payment\n" +
                    "S) Service\n" +
                    "X) Exit\n");
                ConsoleKey userChoice = Console.ReadKey(true).Key;
                Console.Clear();

                switch (userChoice)
                {
                    case ConsoleKey.B:
                        Console.WriteLine("You owe $750");
                        break;
                    case ConsoleKey.P:
                        Console.WriteLine("You made a payment");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("Service? OK.");
                        break;
                    case ConsoleKey.X:
                    case ConsoleKey.E:
                        Console.Clear();
                        Console.WriteLine("Thanks for using the program!");
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("User input not recognized");
                        break;
                }


            } while (repeat);
        }
    }
}
