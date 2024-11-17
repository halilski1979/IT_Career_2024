namespace p03___SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"s={s}");
        }
    }
}
