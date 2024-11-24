namespace p00___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    for (int k = 1; k < 5; k++)
                    {
                        Console.WriteLine($"{i} {j} {k}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

           
        }
    }
}
