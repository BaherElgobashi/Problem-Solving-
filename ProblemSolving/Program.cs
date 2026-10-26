namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            long n = long.Parse(parts[0]);
            long k = long.Parse(parts[1]);
            if(n >= k)
            {
                Console.WriteLine("YES");
            }
            else
                Console.WriteLine("NO");
           
            
            
            
            

 






        }
    }
}
