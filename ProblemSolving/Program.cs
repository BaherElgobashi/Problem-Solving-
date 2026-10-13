namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double x = double.Parse(parts[0]);
            double a = double.Parse(parts[1]);
            double b = double.Parse(parts[2]);

            double number = (x*a +b);

            Console.WriteLine($"{number:F8}");

            


        }
    }
}
