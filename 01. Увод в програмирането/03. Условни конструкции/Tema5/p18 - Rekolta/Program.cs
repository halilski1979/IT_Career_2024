namespace p18___Rekolta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var z = double.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var h = (x * y) * 0.4;
            var w = (h / 2.5);
            if (w >= z)
            {
                var left = w - z;
                Console.WriteLine($"Good harvest this year!Total wine: {w}  liters.");
                Console.WriteLine($"{Math.Ceiling(left)} liters left ->{left / workers} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {z - w:f0} liters wine needed.");
            }
        }
    }
}
