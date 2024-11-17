namespace p11___Number_In_1_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            int num = int.Parse(Console.ReadLine());
            
            while (num<1 || num>100)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Еnter a number in the range [1...100]: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {num}");

        }
    }
}
