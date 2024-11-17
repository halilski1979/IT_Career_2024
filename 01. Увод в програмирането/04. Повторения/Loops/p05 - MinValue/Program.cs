namespace p05___MinValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int br=int.Parse(Console.ReadLine());
            int min=int.MaxValue;

            for (int i = 0; i < br; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine($"Min={min}");
        }
    }
}
