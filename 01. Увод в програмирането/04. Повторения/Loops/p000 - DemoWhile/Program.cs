namespace p000___DemoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int i = 0;
            
            //Условие за край вътре в цикъла
            while (true)
            {
                Console.WriteLine(i);
                i++;
                if (i >= 11)
                    break;
            }


        }
    }
}
