using System.Threading.Channels;

namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);


           long p = long.Parse(parts[0]); 
           long d = long.Parse(parts[1]); 
           long k = long.Parse(parts[2]); 

           long ans = p;

           long option1 = Math.Max(0 , p-d);

            ans = Math.Min(ans , option1);

            if( p >= k)
            {
                long option2 = p / 2;
                ans = Math.Min(ans , option2);
            }
           
           System.Console.WriteLine(ans);

           
           

           
            

            

            





        }
    }
}
