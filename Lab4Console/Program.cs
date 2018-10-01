using System;

namespace Lab4Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int minExclusive = 0;
            int maxExclusive = 11;

            string message = "Make number from " + (minExclusive + 1) + " to " + (maxExclusive - 1);
            Console.WriteLine(message);
            Console.ReadLine();

            while (true)
            {
                int guess = (minExclusive + 1) + (maxExclusive - 1 - minExclusive) / 2;

                Console.WriteLine("Is this " + guess + "? Enter eiteher '>', '<' or '='.");
                string symbol = Console.ReadLine();
                if (symbol == ">")
                {
                    minExclusive = guess;
                }
                else if (symbol == "<")
                {
                    maxExclusive = guess;
                }
                else if (symbol == "=")
                {
                    Console.WriteLine("Bingo!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong answer format.");
                }
                if (minExclusive + 1 == maxExclusive)
                {
                    Console.WriteLine("Your number is " + (minExclusive + 1).ToString());
                    break;
                }
            }
        }
    }
}  

