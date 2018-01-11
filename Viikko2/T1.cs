using System;

namespace Viikko2
{
    class T1
    {
        static void Main(string[] args)
        {
            Console.Write("Anna numero:\n>");
            int n = 0;
            int.TryParse(Console.ReadLine(), out n);
            switch (n)
            {
                case 1:
                    Console.Write("\nNumero on yksi.");
                    break;
                case 2:
                    Console.Write("\nNumero on kaksi.");
                    break;
                case 3:
                    Console.Write("\nNumero on kolme.");
                    break;
                default:
                    Console.Write("\nNumero on väärä!");
                    break;
            }

        }
    }
}
