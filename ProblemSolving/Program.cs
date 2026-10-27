namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string a = parts[0];
            string b = parts[1];
            if(a.ToLower() == b.ToLower()) Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            













        }
    }
}
