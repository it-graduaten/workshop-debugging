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
                int getal;
                int k = 0;
                do
                {
                    k = 0;
                    getal = reader.ReadLine();
                    while (getal > Math.Pow(2, k))
                    {
                        k--;
                    }
                    Console.WriteLine("2 tot de macht {0}  >=  {0}", k, getal);

                } while (!reader.EndOfStream)

                Console.ReadLine();
            }
        }
    }
}
