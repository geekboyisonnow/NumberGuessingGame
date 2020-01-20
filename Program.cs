using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Think of a number between {MIN} and {MAX}...");
            Console.WriteLine("I will be able to guess it within 20 tries or less!");

            //Console.WriteLine("");
            //Console.ReadLine();
        }

        private const int MIN = 1;
        private const int MAX = 1000000;
        private const int upper = MAX;
        private const int lower = MIN;
        private const int tries = 0;
    }
}
