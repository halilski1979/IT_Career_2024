namespace p02___Alphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            string word = "Ivan";
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} = {(int)(word[i])}");
                s += (int)(word[i]);
            }
            Console.WriteLine(s);
        }
    }
}
