﻿namespace p12___Faktoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int factoriel = 1;

            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
        }
    }
}
