namespace p20___Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            if (sum <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (type == "summer") Console.WriteLine($"Camp - {sum * 0.3:f2}");
                if (type == "winter") Console.WriteLine($"Hotel - {sum * 0.7:f2}");
            }
            else if (sum <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (type == "summer") Console.WriteLine($"Camp - {sum * 0.4:f2}");
                if (type == "winter") Console.WriteLine($"Hotel - {sum * 0.8:f2}");
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {sum * 0.9:f2}");
            }
        }
    }
}
