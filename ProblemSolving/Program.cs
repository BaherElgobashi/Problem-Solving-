namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);


            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double resx = Math.Pow((x2 - x1), 2);
            double resy = Math.Pow((y2 - y1), 2);
            Console.WriteLine(Math.Sqrt(resx + resy));
            
            

 






        }
    }
}
