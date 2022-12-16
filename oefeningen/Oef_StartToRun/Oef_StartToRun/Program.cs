using System;

namespace Oef_StartToRun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aantal km gelopen op trainingsdag: ");
            int.TryParse(Console.ReadLine(), out int trainingsdag);
            Console.Write("Aantal km voor de loopwedstrijd: ");
            int.TryParse(Console.ReadLine(), out int loopwedstrijd);

            int aantalDagen = 0;
            while (trainingsdag > loopwedstrijd) {
                aantalDagen++;
                trainingsdag = trainingsdag * 1.1;

            }
            Console.WriteLine($"Na dag {aantalDagen} is je doel bereikt.");
            Console.ReadLine();
        }
    }
}
