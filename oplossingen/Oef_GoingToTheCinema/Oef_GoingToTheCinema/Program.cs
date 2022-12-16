using System;

namespace Oef_GoingToTheCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int aantal = Movie(100, 15, 0.9);
            Console.WriteLine($"Na {aantal} toegangskaarten is het goedkoper om te werken met een kaart");

            aantal = Movie(100, 10, 0.95);
            Console.WriteLine($"Na {aantal} toegangskaarten is het goedkoper om te werken met een kaart");

            Console.ReadLine();
        }

        public static int Movie(int card, int ticket, double perc)
        {
            int numberOfTickets = 0;
            double priceWithCard = card;
            double priceNoCard = 0;

            while (Math.Ceiling(priceWithCard) >= priceNoCard)
            {
                numberOfTickets++;
                priceNoCard += ticket;
                priceWithCard += ticket * Math.Pow(perc, numberOfTickets);
            }
            return numberOfTickets;
        }
    }
}
