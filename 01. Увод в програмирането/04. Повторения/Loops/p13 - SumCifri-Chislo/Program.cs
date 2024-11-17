namespace p13___SumCifri_Chislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
            int s = 0;

            while (num > 0)
            {
                s += num % 10;
                num /= 10;
            }
            Console.WriteLine(s);
        }
    }
}
