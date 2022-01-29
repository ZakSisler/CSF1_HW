using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF__HWLab
{
    class FruitLoops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loops");


            string[] fruit = {"apples", "oranges", "blueberries", "bananas", "watermelons", "kiwis"};

            for (int i = 0; i < fruit.Length; i++)
            {
                Console.WriteLine(fruit[i]);
            }
            
        }
    }
}
