namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            long x = long.Parse(parts[0]);
            long a = long.Parse(parts[1]);
            long b = long.Parse(parts[2]);

            long DiffA = Math.Abs(x - a);
            long DiffB = Math.Abs(x - b);

            if (DiffA < DiffB)
                Console.WriteLine("A");
            else if(DiffA > DiffB)
                Console.WriteLine("B");
            else Console.WriteLine("TIE\r\n");















        }
    }
}
