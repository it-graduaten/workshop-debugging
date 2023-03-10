using System;

namespace Oef_VerwijderElkNdeTeken
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Geef woord op: ");
            string woord = Console.ReadLine();
            Console.Write("Geef n op: ");
            int.TryParse(Console.ReadLine(), out int n);

            string tekst = VerwijderTeken(woord, n);
            Console.WriteLine($"Het nieuw gevormde woord is {tekst}");
            Console.ReadLine();
        }

        private static string VerwijderTeken(string tekst, int n)
        {
            int i = 0;
            while (i < tekst.Length)
            {
                tekst.Remove(i, 1);
            }

            return tekst;
        }
    }
}