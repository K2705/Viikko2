using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class T3
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku\n> ");
            double n1 = 0;
            double.TryParse(Console.ReadLine(), out n1);
            Console.Write("Toinen luku\n> ");
            double n2 = 0;
            double.TryParse(Console.ReadLine(), out n2);
            Console.Write("Kolmas luku\n> ");
            double n3 = 0;
            double.TryParse(Console.ReadLine(), out n3);

            Console.WriteLine("Summa: " + (n1 + n2 + n3));
            Console.WriteLine("Keskiarvo: " + (n1 + n2 + n3) / 3.0);
        }
    }
}
