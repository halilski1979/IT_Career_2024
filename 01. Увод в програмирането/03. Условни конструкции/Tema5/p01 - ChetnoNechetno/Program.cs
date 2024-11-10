namespace p01___ChetnoNechetno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number %2==0) 
            {
                Console.WriteLine("Chetno");
            }
            else             
            {
                Console.WriteLine("Nechetno");
            }

        }
    }
}
