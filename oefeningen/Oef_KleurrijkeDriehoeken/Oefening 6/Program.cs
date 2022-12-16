using System;

namespace Oefening_6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = i; j < i*3; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 8; i > 0; i++)
            {
                for (int j = i; j < i * 3; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
