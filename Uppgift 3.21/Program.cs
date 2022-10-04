using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett matematiskt uttryck med endast addition.");
            Console.Write("\nSkriv här: "); string[] input = Console.ReadLine().Split('+');

            int[] tal = Array.ConvertAll(input, int.Parse);

            int summa = tal.Sum();

            Console.WriteLine($"\nSumman blir då {summa}.");
        }
    }
}