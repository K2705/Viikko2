using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class T4
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ikä\n> ");
            int n = 0;
            int.TryParse(Console.ReadLine(), out n);

            if (n < 18) Console.WriteLine("\nAlaikäinen");
            if (n >= 18 && n < 65) Console.WriteLine("\nAikuinen");
            if (n >= 65) Console.WriteLine("\nSeniori");
        }
    }
}
