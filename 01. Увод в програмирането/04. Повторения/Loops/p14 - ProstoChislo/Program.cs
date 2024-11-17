namespace p14___ProstoChislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int ostatakNula = 0;
            for (int i = 1; i <= n; i++)
            {
                if(n%i==0)
                {
                  ostatakNula++;
                }
            }

            if (ostatakNula == 2)
            {
                Console.WriteLine("Prime");
            }
            else 
            {
                Console.WriteLine("Not Prime");
            }

        }
    }
}
