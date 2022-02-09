using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c:");
            double c = double.Parse(Console.ReadLine());
            while (c == 0)
            {
                Console.Write("Ты инвалид\nВведите c:");
                c = double.Parse(Console.ReadLine());
            }
            Console.Write("Введите x:");
            double x = double.Parse(Console.ReadLine());

            double y = (x - 1 > 0 && b + x == 0) ? (x - a)/x : (x - 1 < 0 || b - x != 0) ? a * Math.Pow(x, 2) + b : x/c;

            Console.WriteLine(y);
        }
    }
}
