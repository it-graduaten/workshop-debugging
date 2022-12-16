using System;
using System.IO;

namespace Oef_GemiddeldeLeeftijd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gegevens.txt");
            Console.WriteLine(new string('-', 30));
            LeesBestand("gegevens.txt");
            Console.WriteLine();
            Console.WriteLine("gegevens1.txt");
            Console.WriteLine(new string('-', 30));
            LeesBestand("gegevens1.txt");
            Console.ReadLine();
        }

        public static void LeesBestand(string bestandsnaam)
        {
            using (StreamReader reader = new StreamReader(bestandsnaam))
            {
                string naam;
                int leeftijd, somAantal = 0, somLeeftijd = 0;
                while (!reader.EndOfStream)
                {
                    naam = reader.ReadLine();
                    leeftijd = int.Parse(reader.ReadLine());
                    somAantal += 1;
                    somLeeftijd += leeftijd;

                }
                Console.WriteLine("De gemiddelde leeftijd bedraagt:" + ((somLeeftijd * 1.0) / somAantal).ToString());
            }
        }
    }
}
