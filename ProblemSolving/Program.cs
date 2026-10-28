using System.Threading.Channels;

namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);



            long a = long.Parse(parts[0]);
            long b = long.Parse(parts[1]);
            long k = long.Parse(parts[2]);
            long d = long.Parse(parts[3]);

            if( a >= k)
            {
                long ResultA = a - d;
                if(ResultA < 0)
                {
                    Console.WriteLine("TIE");
                    return;
                }
                    
                Console.WriteLine("FIRST\r\n");
            }
            else if (b >= k)
            {
                long ResultB = b - d;
                if (ResultB < 0)
                {
                    Console.WriteLine("TIE");
                    return;
                }
                    
                Console.WriteLine("SECOND\r\n");
            }
           

            

          

        }
    }
}
