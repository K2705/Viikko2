using System;
using System.Collections;


namespace T9
{
    /// <summary>
    /// kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0.
    /// tulostaa syötettyjen lukujen summan.
    /// </summary>
    class T9
    {
        static void Main(string[] args)
        {
            ArrayList luvut = new ArrayList();
            int input = 1; //mielivaltainen arvo joka ei ole 0
            do
            {
                Console.Write("Anna luku (0 lopettaa)\n>");
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    luvut.Add(input);
                }
                else
                {
                    Console.WriteLine("Tuo ei ole luku.");
                    input = 1; //mielivaltainen arvo joka ei ole 0
                }
            } while (input != 0);

            int summa = 0;
            foreach (int luku in luvut)
            {
                summa += luku;
            }

            Console.WriteLine("Lukujen summa on " + summa);
        }
    }
}
