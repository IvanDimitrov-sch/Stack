namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("palyndrome - 2ex");
            Palyndrome();
            
        }
        static void Palyndrome()
        {
            Queue<char> que = new();
            string word = Console.ReadLine();
            char[] charArr = word.ToCharArray();
            foreach (char c in charArr)
            {
                que.Enqueue(c);
            }
            string rev = "";
            char k;
            while (que.Count > 0)
            {
                k = que.Dequeue();
                rev += k;
            }
            if (rev.Equals(word))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
