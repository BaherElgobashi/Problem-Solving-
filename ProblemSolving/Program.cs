namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            long a = long.Parse(parts[0]);
            long b = long.Parse(parts[1]);
            long k = long.Parse(parts[2]);

            long shelfA = (a - 1) / k;
            long shelfB = (b - 1) / k;

            if (shelfA == shelfB)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }













        }
    }
}
