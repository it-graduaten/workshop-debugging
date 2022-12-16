using System;

namespace Oef_SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            sum = rowSumOddNumbers(1);
            Console.WriteLine($"De som van alle getallen tem index 1 is {sum}");
            sum = rowSumOddNumbers(2);
            Console.WriteLine($"De som van alle getallen tem index 2 is {sum}");
            sum = rowSumOddNumbers(42);
            Console.WriteLine($"De som van alle getallen tem index 42 is {sum}");

            Console.ReadLine();


        }

        public static int rowSumOddNumbers(string n)
        {
            int sum;
            for (int i = 0; i <= n; i++)
            {
                sum += 1 + n * (n - 1) + 2 * i;
            }
            return sum;
        }
    }
}
