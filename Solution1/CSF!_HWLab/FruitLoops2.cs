using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF__HWLab
{
    class FruitLoops2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loops 2");

            string[] fruit = { "apples\n .", "oranges\n..", "blueberries\n...", "bananas\n....", "watermelons\n.....", "kiwis\n......" };

            for (int i = 0; i < fruit.Length; i++)
            {
                Console.WriteLine(fruit[i]);
            }

        }
    }
}
