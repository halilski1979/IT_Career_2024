namespace p06_EqualSum_LeftRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum=0;

            //Сума на лява редица
            for (int i = 0; i < br; i++)
            {
                int num=int.Parse(Console.ReadLine());
                leftSum += num;
            }

            //Сума на дясна редица
            for (int i = 0; i < br; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum += num;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum-rightSum)}");
            }


        }
    }
}
