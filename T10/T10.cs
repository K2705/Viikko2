using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10
{
    class T10
    {
        /// <summary>
        /// Prints a hardcoded string every time a number in a hardcoded array is even.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const String HEPTEXT = "HEP";
            int[] luvut = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i = 0; i < luvut.Length; i++)
            {
                if (luvut[i] % 2 == 0) Console.WriteLine(HEPTEXT);
            }
        }
    }
}
