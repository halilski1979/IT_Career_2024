namespace p07___OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            int chetnaSuma = 0;
            int nechetnaSuma = 0;
            for (int i = 0; i < br; i++)
            { 
                int num=int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    chetnaSuma += num;
                }
                else if (i % 2 == 1)
                {
                    nechetnaSuma += num;
                }
            }
            if (chetnaSuma ==nechetnaSuma)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {chetnaSuma}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(chetnaSuma-nechetnaSuma)}");
            }
        }
    }
}
