using System;
using System.IO;

namespace Oef_Machten
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("gegevens.txt"))
            {
                
                int k = 0;
                while (!reader.EndOfStream)
                {
                    k = 0;
                    int.TryParse(reader.ReadLine(), out int getal);
                    while (getal > Math.Pow(2, k))
                    {
                        k++;
                    }
                    Console.WriteLine("2 tot de macht {0}  >=  {1}", k, getal);
                } 
                Console.ReadLine();
            }
        }
    }
}
