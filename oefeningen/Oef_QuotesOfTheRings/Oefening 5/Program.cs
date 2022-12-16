using System;

namespace Oefening_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Quote[] quotes = new Quote[]
            {
                new Quote("Gandalf", "There is only one Lord of the Ring, only one who can bend it to his will. And he does not share power."),
                new Quote("Gollum", "We swears, to serve the master of the Precious. We will swear on… on the Precious!"),
                new Quote("Treebeard", "There is no curse in Elvish, Entish, or the tongues of Men for this treachery."),
                new Quote("Arwen", "I would rather share one lifetime with you than face all the Ages of this world alone."),
                new Quote("Aragorn", "A day may come when the courage of men fails… but it is not THIS day."),
                new Quote("Gimli", "I cannot jump the distance, you´ll have to toss me. Don´t tell the elf."),
                new Quote("Legolas", "They're taking the Hobbits to Isengard")
            };
            int input;
            Random random = new Random();
            do
            {
                Console.WriteLine("Type 1 to generate a random quote from Lord of the Rings!");
                Console.WriteLine("Type 0 to stop");
                Console.WriteLine();
                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out input);
                if (input == 1)
                {
                    int index = random.Next(0, quotes.Length);
                    Console.WriteLine();
                    Console.WriteLine($"{quotes[index].Name}: {quotes[index].Text}");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to try again!");
                    Console.ReadLine();
                }
                Console.Clear();
            } while (input != 0);
        }
        public class Quote
        {
            public string Name { get; set; }
            public string Text { get; set; }
            public Quote(string name, string text)
            {
                Name = name;
                Text = text;
            }
        }
    }
}
