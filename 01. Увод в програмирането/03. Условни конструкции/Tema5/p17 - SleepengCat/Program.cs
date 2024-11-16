namespace p17___SleepengCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int playtime = (365 - days) * 63 + days * 127;
            int h = Math.Abs((30000 - playtime) / 60);
            int m = Math.Abs((30000 - playtime) % 60);

            if (playtime < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{h} hours and {m} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{h} hours and {m} minutes more for play");
            }
        }
    }
}
