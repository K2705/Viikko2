using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class T6
    {
        static void Main(string[] args)
        {
            const double GAS_PRICE = 1.595;
            const double GAS_CONSUMPTION = 7.02 / 100;

            Console.Write("Anna matka\n> ");
            double n = 0;
            double.TryParse(Console.ReadLine(), out n);

            double gasUse = GAS_CONSUMPTION * n;
            double gasCost = gasUse * GAS_PRICE;

            Console.WriteLine("\nBensaa kuluu " + gasUse + " litraa ja se maksaa " + gasCost + " euroa.");
        }
    }
}
