namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            long x = long.Parse(parts[0]);
            long y = long.Parse(parts[1]);

            if( x == 0 || y == 0) Console.WriteLine(0);

            else if (x > 0 && y > 0) Console.WriteLine(1);

            else if (x < 0 && y > 0) Console.WriteLine(2);

            else if (x < 0 && y < 0) Console.WriteLine(3);

            else if (x > 0 && y < 0) Console.WriteLine(4);
            

            

            















        }
    }
}
