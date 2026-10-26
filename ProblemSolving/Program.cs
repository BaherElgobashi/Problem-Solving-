namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            long n = long.Parse(parts[0]);
            long r = long.Parse(parts[1]);
            if(n >= r)
            {
                Console.WriteLine(n-r);
            }
            else
                Console.WriteLine(-1);
           
            
            
            
            

 






        }
    }
}
