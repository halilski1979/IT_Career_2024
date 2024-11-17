namespace p04___MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int br=int.Parse(Console.ReadLine());
           int max=int.MinValue;
            
            for (int i = 0; i < br; i++) 
            { 
               int num=int.Parse(Console.ReadLine());
              if (max<num)
                {
                    max= num;
                }
            }
            Console.WriteLine($"Max={max}");
            
        }
    }
}
