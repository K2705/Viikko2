using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class T7
    {
        static void Main(string[] args)
        {
            Console.Write("Anna vuosi\n> ");
            int n = 0;
            int.TryParse(Console.ReadLine(), out n);

            bool karkausvuosi = false;
            if ((n % 4) == 0) karkausvuosi = true;
            if ((n % 100) == 0) karkausvuosi = false;
            if ((n % 400) == 0) karkausvuosi = true;

            Console.WriteLine("Vuosi " + n + (karkausvuosi ? " on karkausvuosi." : " ei ole karkausvuosi."));
        }
    }
}
