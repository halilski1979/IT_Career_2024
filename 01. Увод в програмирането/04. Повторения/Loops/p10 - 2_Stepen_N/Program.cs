namespace p10___2_Stepen_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"2^{i}={num}");
                num *= 2;
            }

        }
    }
}
