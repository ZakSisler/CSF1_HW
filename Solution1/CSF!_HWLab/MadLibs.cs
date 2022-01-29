using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF__HWLab
{
    class MadLibs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mad Libs!");

            Console.WriteLine("Give me a noun: ");
            string season = Console.ReadLine();
            Console.WriteLine("A verb: ");
            string car = Console.ReadLine();
            Console.WriteLine("An adjective: ");
            string show = Console.ReadLine();
            Console.WriteLine("A silly name: ");
            string cash = Console.ReadLine();

            Console.WriteLine("\nThe {0} {1} and {2} called you {3} as you were reading this... \n\nYeah, this was a short story.\n", season, car, show, cash);

        }
    }
}
