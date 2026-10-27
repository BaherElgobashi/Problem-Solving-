using System.Threading.Channels;

namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string s = Console.ReadLine();

            long a = (long)s[0];
            long b = (long)s[1];
            long c = (long)s[2];

           

            if(b > a && b < c) Console.WriteLine("YES");
            else if(b < a && b > c) Console.WriteLine("YES");
            else Console.WriteLine("NO");

        }
    }
}
