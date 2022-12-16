#pragma warning disable CS0642
using System;

namespace Oefening_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] locaties = new string[]
            {  
                "Mechelen",
                "Sint-Katelijne-Waver",
                "Geel",
                "Lier",
                "Antwerpen",
                "Turnhout",
                "Vorselaar"
            };
            Console.WriteLine("Lijst van enkele locaties waar we Thomas More campussen vinden: \n");

            for (int i = 0; i < locaties.GetUpperBound(0); i++);
            {
                Console.WriteLine(locaties[i]);
            }

            Console.WriteLine("\nKlaar met locaties tonen");
            Console.ReadLine();
        }
    }
}
