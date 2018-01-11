using System;

namespace T8
{
    class T8
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku\n> ");
            int n1 = 0;
            int.TryParse(Console.ReadLine(), out n1);
            Console.Write("Toinen luku\n> ");
            int n2 = 0;
            int.TryParse(Console.ReadLine(), out n2);
            Console.Write("Kolmas luku\n> ");
            int n3 = 0;
            int.TryParse(Console.ReadLine(), out n3);

            Console.WriteLine("Suurin luku on " + SuurinKolmesta(n1, n2, n3));
        }

        /// <summary>
        /// Palauttaa kolmesta luvusta suurimman.
        /// Jos luvut ovat yhtä suuria, niistä palautetaan ensimmäinen.
        /// </summary>
        /// <param name="n1">1. luku</param>
        /// <param name="n2">2. luku</param>
        /// <param name="n3">3. luku</param>
        /// <returns>luvuista suurin</returns>
        private static int SuurinKolmesta(int n1, int n2, int n3)
        {
            int suurin = n1;
            if (n2 > suurin) suurin = n2;
            if (n3 > suurin) suurin = n3;
            return suurin;
        }
    }
}
