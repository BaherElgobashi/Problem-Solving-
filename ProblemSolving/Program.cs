namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            long w = long.Parse(parts[0]);
            long h = long.Parse(parts[1]);
            long a = long.Parse(parts[2]);
            long b = long.Parse(parts[3]);

            if((w <= b && h <= a) || (w <=a && h <=b)) Console.WriteLine("YES\r\n");
            else Console.WriteLine("NO\r\n");

            















        }
    }
}
