using System;

namespace Oef_SwapPlaces
{
    class Program
    {
        //Schrijf de code om de inhoud van twee variabelen A en B van plaats te verwisselen.
        static void Main(string[] args)
        {
            //variabelen declareren
            string a, b, c;

            //data inlezen
            Console.Write("geef eerste waarde in ");
            a = Console.ReadLine();
            Console.Write("geef tweede waarde in ");
            b = Console.ReadLine();

            //berekeningen
            c = a;
            a = b;
            b = c;

            //data tonen
            Console.WriteLine("Na omwisseling is de eerste waarde {0} en de tweede waarde {1} geworden.", a, b);
            Console.ReadLine();
        }
    }
}
