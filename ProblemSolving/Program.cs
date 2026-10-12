namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            long t = long.Parse(parts[0]);
            long s = long.Parse(parts[1]);
            //long m = long.Parse(parts[2]);

            Console.WriteLine(t - (s*1000));



        }
    }
}
