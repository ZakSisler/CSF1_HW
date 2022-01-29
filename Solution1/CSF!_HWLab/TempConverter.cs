using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF__HWLab
{
    class TempConverter
    {
        static void Main(string[] args)
        {

            bool repeat = true;

            do
            {


                Console.WriteLine();
                Console.WriteLine("Temp Converter");

                Console.WriteLine("\n\nPlease choose a Temperature:\n" +
                   "1) Celsius converted to Fahrenheit: Press \"A\"\n" +
                   "2) Fahrenheit converted to Celsius: Press \"B\"\n");

                ConsoleKey userChoice = Console.ReadKey(true).Key;
                Console.Clear();

                switch (userChoice)
                {
                    case ConsoleKey.A:
                        Console.Write("What is the current temperature in Celsius? ");
                        int userCelInput = Convert.ToInt16(Console.ReadLine());
                        int toFahConversion = userCelInput * 9 / 5 + 32;
                        Console.WriteLine("Celsius is " + toFahConversion);
                        break;
                    case ConsoleKey.B:
                        Console.Write("What is the current temp in Fahrenheit? ");
                        int userFahInput = Convert.ToInt16(Console.ReadLine());
                        int toCelConversion = (userFahInput - 32) * 5 / 9;
                        Console.WriteLine("Fahrenheit is " + toCelConversion);
                        break;
                        
                    default:
                        Console.Write("ERROR: INVALID SELECTION");
                        break;
                }

            } while (repeat);

        }
    }
}
//Console.WriteLine("What is the current temperature in Celsius? ");
//int userCelInput = Convert.ToInt16(Console.ReadLine());

//int toFahConversion = userCelInput * (9 / 5) + 32;

//Console.WriteLine("What is the current temp in Fahrenheit? ");
//int userFahInput = Convert.ToInt16(Console.ReadLine());

//int toCelConversion = (userFahInput - 32) / (9 / 5);
