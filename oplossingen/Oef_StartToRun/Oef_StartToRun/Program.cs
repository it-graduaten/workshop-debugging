using System;

namespace Oef_StartToRun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aantal km gelopen op trainingsdag: ");
            double.TryParse(Console.ReadLine(), out double trainingsdag);
            Console.Write("Aantal km voor de loopwedstrijd: ");
            double.TryParse(Console.ReadLine(), out double loopwedstrijd);

            int aantalDagen = 1;
            while (trainingsdag < loopwedstrijd) {
                aantalDagen++;
                trainingsdag = trainingsdag * 1.1;

            }
            Console.WriteLine($"Na dag {aantalDagen} is je doel bereikt.");
            Console.ReadLine();
        }
    }
}
