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

            long x = a;

            if(x >= k)
            {
                x = Math.Max(0 , x-d);
            }

            long y = b;

            if (y >= k)
            {
                y = Math.Max(0, y - d);
            }

            if(x < y)
                Console.WriteLine("FIRST");

            else if(x > y)
                Console.WriteLine("SECOND");
            else
                Console.WriteLine("TIE");





        }
    }
}
