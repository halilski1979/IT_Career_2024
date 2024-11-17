namespace p08___NumberEqualOtherNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int br=int.Parse(Console.ReadLine());
            int max=int.MinValue;
            int s = 0;
            for (int i = 0; i < br; i++)
            { 
                int num=int.Parse(Console.ReadLine());
                //Намираме MAX
                if (num>max)
                {
                    max = num;
                }
                //Намираме сбор на всички числа
                s += num;
            }

            if (s-max==max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {s-max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs((s-max)-max)}");
            }
        }
    }
}
