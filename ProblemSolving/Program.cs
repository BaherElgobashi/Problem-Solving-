namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            long m = long.Parse(parts[0]);
            long a = long.Parse(parts[1]);
            long b= long.Parse(parts[2]);
            long c = long.Parse(parts[3]);

            Console.WriteLine((m*4) - (a+b+c));


        }
    }
}
