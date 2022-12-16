using System;

namespace Oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alfabetZonderZ = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y' };
            
            for (int i = 0; i <= alfabetZonderZ.Length; i+=5)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(alfabetZonderZ[i+j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
