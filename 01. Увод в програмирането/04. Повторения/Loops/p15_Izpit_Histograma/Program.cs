﻿namespace p15_Izpit_Histograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
            int p1=0; 
            int p2=0;
            int p3=0;
            int p4=0;
            int p5=0;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                else if (num < 400)
                {
                    p2++;
                }
                else if (num <600)
                {
                    p3++;
                }
                else if(num <800)
                {
                    p4++;
                }
                else if (num < 1000)
                {
                    p5++;
                }
            }

            Console.WriteLine($"{((double)(p1)/(double)(n)) * 100:f2}%");
            Console.WriteLine($"{((double)(p2) / (double)(n)) * 100:f2}%");
            Console.WriteLine($"{((double)(p3) / (double)(n)) * 100:f2}%");
            Console.WriteLine($"{((double)(p4) / (double)(n)) * 100:f2}%");
            Console.WriteLine($"{((double)(p5) / (double)(n)) * 100:f2}%");
        }
    }
}
