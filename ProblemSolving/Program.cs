namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            long a = long.Parse(parts[0]);
            long b = long.Parse(parts[1]);
            long x = long.Parse(parts[2]);

            

             if( x >= a && x <= b) Console.WriteLine("ON_TIME\r\n");

            else if (x < a) Console.WriteLine("EARLY\r\n");
            else if (x > b) Console.WriteLine("LATE\r\n");
            















        }
    }
}
