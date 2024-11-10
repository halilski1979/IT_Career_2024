namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m=int.Parse(Console.ReadLine()) ;

            m += 15;

            if (m>60)
            {
                h += 1;
                m=m-60;
            }

            if (h>=24)
            {
                h -= 24;
            }

            if(m<10)
            {
                Console.WriteLine($"{h}:0{m}");
            }
            else 
            {
                Console.WriteLine($"{h}:{m}");
            }



        }
    }
}
