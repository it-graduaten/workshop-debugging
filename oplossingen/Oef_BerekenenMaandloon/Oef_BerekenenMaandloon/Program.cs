using System;

namespace Oef_BerekenenMaandloon
{
    class Program
    {
        static void Main(string[] args)
        {

            //variabelen declareren
            double brutoUurloon, nettoloon, belasting;
            int aantalUren, overuren = 0;

            //data inlezen
            Console.WriteLine("Geef het brutoloon");
            double.TryParse(Console.ReadLine(), out brutoUurloon);

            Console.WriteLine("Geef het aantal uren");
            int.TryParse(Console.ReadLine(), out aantalUren);

            //berekeningen
            if (aantalUren > 36)
            {
                overuren = aantalUren - 36;
            }

            nettoloon = (36 + overuren * 2) * brutoUurloon * 0.8;
            belasting = (36 + overuren * 2) * brutoUurloon * 0.2;

            Console.WriteLine("Het nettoloon bedraagt {0}", nettoloon);
            Console.WriteLine("De belasting bedraagt {0}", belasting);
            Console.ReadLine();


        }
    }
}
