using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class T2
    {
        static void Main(string[] args)
        {
            Console.Write("Montako pistettä?\n> ");
            int n = 0;
            int.TryParse(Console.ReadLine(), out n);

            if (n < 0 || n >= 13) Console.Write("Eikä ole.");
            else
            {
                Console.Write("\nNumeroksi tulee ");
                if (n >= 0 && n < 2) Console.Write("0");
                if (n >= 2 && n < 4) Console.Write("1");
                if (n >= 4 && n < 6) Console.Write("2");
                if (n >= 6 && n < 8) Console.Write("3");
                if (n >= 8 && n < 10) Console.Write("4");
                if (n >= 10 && n < 13) Console.Write("5");
            }
            Console.WriteLine();
        }
    }
}

