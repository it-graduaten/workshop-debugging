using System;
using System.IO;

namespace Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = string.Empty;
            int choice = -1;

            ShowMenu();
            Console.Write("Keuze: ");
            int.TryParse(Console.ReadLine(), out choice);

            while (choice != 7)
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("\n\nNieuwe waarde: ");
                        value = Console.ReadLine();
                        break;
                    case 2:
                        string result = value == string.Empty ? "\nJe moet eerst een waarde invullen voor ze kan getoond worden" : $"\nWaarde: {value}";
                        Console.WriteLine(result);
                        Console.WriteLine("\nDruk op enter om verder te gaan");
                        Console.ReadLine();
                        break;
                    case 3:
                        value = string.Empty;
                        Console.WriteLine("\nWaarde is leeg");
                        Console.WriteLine("\nDruk op enter om verder te gaan");
                        Console.ReadLine();
                        break;
                    case 7:
                        if (value != string.Empty)
                        {
                            ExportResponse(value);
                            Console.WriteLine("\nWaarde is weggeschreven");
                            Console.WriteLine("\nDruk op enter om het programma af te sluiten");
                            Console.ReadLine();
                        }
                        else
                        {
                            choice = 0;
                            Console.WriteLine("\nJe moet eerst een waarde invullen voor ze kan weggeschreven worden");
                            Console.WriteLine("\nProbeer opnieuw");
                            Console.ReadLine();
                        }
                        break;
                }
                ShowMenu();
                Console.Write("Keuze: ");
                int.TryParse(Console.ReadLine(), out choice);
            }
        }

        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(
                "Druk 1 om een nieuwe waarde in te geven\n" +
                "Druk 2 om een de ingegeven waarde te tonen\n" +
                "Druk 3 om de ingegeven waarde te verwijderen\n" +
                "Druk 7 om de ingegeven waarde weg te schrijven naar een bestand\n"
             );
        }

        public static void ExportResponse(string value)
        {
            using(StreamWriter writer = new StreamWriter("value.txt"))
            {
                writer.WriteLine(value);
            }
        }
    }
}
