using System;

namespace T5
{
    class T5
    {
        static void Main(string[] args)
        {
            Console.Write("Anna sekunnit\n> ");
            int input = 0;
            int.TryParse(Console.ReadLine(), out input);

            int s = input % 60;

            int min = (input % (60 * 60)) / 60;

            int h = input / (60 * 60);

            Console.WriteLine("Aika on " + h + " tuntia, " + min + " minuuttia ja " + s + " sekuntia.");
        }
    }
}
