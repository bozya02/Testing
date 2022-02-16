using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a:");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter b:");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter c:");
            double c = double.Parse(Console.ReadLine());

            Console.Write("Enter x:");
            double x = double.Parse(Console.ReadLine());

            double y = (c > 0 && b == 0) ? (x + a) / (x + c) : (c < 0 || b != 0) ? a * Math.Pow(x, 2) + Math.Pow(b, 2) * x : x/c;

            Console.WriteLine(y);
        }
    }
}
