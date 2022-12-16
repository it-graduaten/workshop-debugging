using System;

namespace Oef_BerekenenMaandloon
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                //variabelen declareren
                double brutoUurloon, nettoloon, belasting;
                int aantalUren, overuren = 0;

                //data inlezen
                Console.WriteLine("Geef het brutoloon");
                brutoUurloon = double.Parse(Console.ReadLine());

                Console.WriteLine("Geef het aantal uren");
                aantalUren = byte.Parse(Console.ReadLine());

                //berekeningen
                if aantalUren > 36
                {
                    overuren = aantalUren - 36;
                }

                nettoloon = 36 + overuren * brutoUurloon * 0.8;
                belasting = 36 + overuren * brutoUurloon * 0.2;

                Console.WriteLine("Het nettoloon bedraagt {0}", nettoloon);
                Console.WriteLine("De belasting bedraagt {0}", belasting);
                Console.ReadLine();

            
        }
}
