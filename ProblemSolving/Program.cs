namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long n = long.Parse(parts[0]);

             if(n == 0)
            {
                Console.WriteLine(1);
            }
             else if( n == 1)
            {
                Console.WriteLine(5);
            }
            else
            {
                Console.WriteLine(25);
            }









        }
    }
}
