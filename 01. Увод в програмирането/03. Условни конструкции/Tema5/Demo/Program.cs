namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char day = char.Parse(Console.ReadLine()); 
           
            switch (day)
            {
                case '!':                      
                        Console.WriteLine("Pon");
                        Console.WriteLine("Monday");                    
                break;

                case '@':
                    {
                        Console.WriteLine("Vt");
                        Console.WriteLine("Tuesday");
                    }
                    break;
                case '#':
                    {
                        Console.WriteLine("Ne");
                        Console.WriteLine("Sunday");
                    }
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }           

        }
    }
}
