using System;
using System.IO;

namespace Voorbeeld_Debuggen_Console
{
    class Program
    {
       


        static void Main(string[] args)
        {
            Syntaxfouten();
            //Runtimefouten1();
            //Runtimefouten2();
            //LogischeFouten1();
            //LogischeFouten2();
            //Uitnodiging();
            //SwapPlaces();
            ////Kerstboom();
        }

        private static void Syntaxfouten()
        {

            //Het programma vraagt de gebruiker om een startwaarde, een geheel getal groter dan of gelijk aan 3. 
            //Stel dat de gebruiker bv. 10 ingeeft, dan schrijft het hoofdprogramma van deze klasse de volgende tekst uit op het scherm:
            //10 9 8 7 6 5 4 3 2 1 START
            //Zolang die startwaarde kleiner is dan 3, vraagt het programma een nieuwe startwaarde. 
            //Is de startwaarde wel in orde, dan wordt er vanaf dat getal afgeteld. Een mogelijk programmaverloop:
            //Geef een getal >= 3: 2
            //Geef een getal >= 3: -1
            //Geef een getal >= 3: 7
            //7 6 5 4 3 2 1 START


            //declareren en initialiseren

            int invoer;
            string tekst;

            //waarden inlezen
            while (invoer < 3)
            {
                Console.WriteLine("Geef een getal >= 3:");
                invoer = Console.ReadLine();
            }

            while (invoer >= 1) ;
            {
                Console.Write(--invoer + " ");
            }
            Console.Write(" START");
            Console.ReadLine();

        }

        private static void Runtimefouten1()
        {
            //voorbeeld 1
            //declareren
            string woord = "";
            //inlezen en initialiseren
            Console.WriteLine("Geef een willekeurig woord in (max 10 karakters):");
            woord = Console.ReadLine();
            //afdrukken
            Console.WriteLine($"De laatste letter van {woord} is {woord.Substring(10)}");
            Console.ReadLine();
        }

        private static void Runtimefouten2()
        {
            //voorbeeld2
            string tekst = "";
            StreamReader s = new StreamReader("bestandl.txt");
            while (!s.EndOfStream)
            {
                tekst = s.ReadToEnd();
            }
            Console.WriteLine(tekst);
            Console.ReadLine();
        }
        private static void LogischeFouten1()
        {
            string tekst = "";
            StreamReader s = new StreamReader("bestand1.txt");
            while (s.EndOfStream)
            {
                tekst = s.ReadToEnd();
            }
            Console.WriteLine(tekst);
            Console.ReadLine();
        }

        private static void LogischeFouten2()
        {
            double prijsExclusief, prijsInclusief = 0;
            Console.Write("Geef de prijs exclusief: ");
            if (double.TryParse(Console.ReadLine(), out prijsExclusief))
            {
                prijsInclusief = BerekenPrijsInclusief(prijsExclusief, 21);
            }
            Console.WriteLine($"Prijs inclusief btw: {prijsExclusief.ToString("0.00")}");
            Console.ReadLine();
        }
        private static double BerekenPrijsInclusief(double prijsExclusief, int btwPercentage)
        {
            double inclusief = prijsExclusief * (1 + btwPercentage / 100);
            return inclusief;
        }


        private static void Uitnodiging()
        {
            string activiteit, datumUurActiviteit, smsAntwoordje;
            bool benJeVrij;
            Console.WriteLine("Ontvangen SMS-bericht")
            Console.Write("Voor welke activiteit kreeg je een sms-bericht?");
            activiteit = Console.ReadLine();

            Console.Write($"Geef datum en uur dat {activiteit} zal doorgaan?");
            datumUurActiviteit = Console.ReadLine();

            Console.WriteLine($"Ben je vrij op {datumUurActiviteit} ('true' of 'false')?");
            benJeVrij = Console.ReadLine();

            if (benJeVrij == false)
            {
                smsAntwoord = "Ik zal er zijn";
            }
            else
            {
                smsAntwoord = "Spijtig, het zal voor een andere keer zijn!";
            }

            //resultaat tonen
            Console.WriteLine(smsAntwoord);
            //wachten op enter
            Console.WriteLine();
            Console.Write("Druk op enter om verder te gaan!");
            Console.ReadLine();


        }

        private static void SwapPlaces()
        {
            //variabelen declareren
            string a, b, d;

            //data inlezen
            Console.Write("geef eerste waarde in ");
            a = Console.ReadLine()
            Console.Write("geef tweede waarde in ");
            b = Console.ReadLine();

            //berekeningen
            c = a;
            a = c;
            b = a;

            //data tonen
            Console.WriteLine("Na omwisseling is de eerste waarde {0} en de tweede waarde {0} geworden.", a, b);
            Console.ReadLine();
        }

        private static void Kerstboom()
        {
            int aantalSter = 1;
            int aantalSpaties = 14;
            for (int rij = 0; rij < 15; rij++)
            {
                for (int spaties = 14; spaties > rij; spaties++)
                {
                    Console.Write(new string(' ', aantalSpaties));
                }
              
                Console.WriteLine(new string('*', aantalSter));
                aantalSter += 2;
                
            }
            Console.ReadLine();
        }
    }
}
