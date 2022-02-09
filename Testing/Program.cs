using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double y = (c < 0 || b != 0) ? a * Math.Pow(x, 2) + Math.Pow(b, 2) * x : (c > 0 && b == 0) ? (x + a)/(x + c) : x/c;

            Console.WriteLine(y);
        }
    }
}
