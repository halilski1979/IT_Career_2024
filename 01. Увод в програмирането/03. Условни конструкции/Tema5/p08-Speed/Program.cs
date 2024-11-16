using System.Threading.Channels;

namespace p08_Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());

            if (n < 10)
            {
                Console.WriteLine("Slow");
            }
            else if ( n <= 50)
            {
                Console.WriteLine("Average");
            }
            else if ( n <= 150)
            {
                Console.WriteLine("Fast");
            }
            else if ( n <= 1000)
            {
                Console.WriteLine("UltraFast");
            }
            else 
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
