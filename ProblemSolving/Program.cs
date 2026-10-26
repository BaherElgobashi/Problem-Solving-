namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            long h = long.Parse(parts[0]);
            if(h == 23 || h == 22 || h == 0 || h ==1 || h == 2 || h == 3 || h == 4 || h == 5 || h==6)
                Console.WriteLine("QUIET\r\n");
            else
                Console.WriteLine("OPEN\r\n");
           
            
            
            
            

 






        }
    }
}
