using System;

namespace Oefening_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersAsWords = new string[]
            {
                "One",
                "Two",
                "Three",
                "Four",
                "Five",
                "Six",
                "Seven",
                "Eight",
                "Nine",
                "Ten",
            };

            for (int i = 0; i < numbersAsWords.GetUpperBound(0); i++)
            {
                Console.WriteLine($"{i} is written as {numbersAsWords[i]}");
            }
        }
    }
}
