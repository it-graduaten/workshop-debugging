using System;


namespace Oef_ZonderKlinkers
{
    class Program
    {
        /*
         * Schrijf een functie zonder_klinkers waaraan twee locaties van tekstbestanden (str) moeten doorgegeven worden. 
         * De functie moet de inhoud van het eerste tekstbestand kopiëren naar het tweede tekstbestand, 
         * maar waarbij alle klinkers verwijderd worden. 
         * De functie moet een tuple met twee elementen teruggeven: 
         * i) het totaal aantal karakters dat werd ingelezen uit het eerste tekstbestand en 
         * ii) het totaal aantal karakters dat werd uitgeschreven naar het tweede tekstbestand.
         * */
        static void Main(string[] args)
        {
            string tekst = ZonderKlinkers("gegevens.txt", "output.txt");
            Console.WriteLine("De volgende tekst is weggeschreven:");
            Console.WriteLine(tekst);
            Console.ReadLine();
        }

        private static string ZonderKlinkers(string inBestand, string outBestand)
        {
           
            using (StreamReader reader = new StreamReader(inBestand))
            {
                while (!reader.EndOfStream)
                {
                    string tekst = reader.ReadToEnd();
                    tekst.Replace("i", "").Replace("a", "").Replace("e", "").Replace("o", "").Replace("u", "");
                    return tekst;
                }
            }
            using (StreamWriter writer = new StreamWriter(outBestand))
            {
                writer.Write(tekst);
            }
           
        }
    }
}
