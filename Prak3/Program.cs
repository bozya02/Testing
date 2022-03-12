using System;

namespace Prak3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double a = 0;
            double b = 2;
            double e;
            try
            {
                e = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Entered value is not number");
                return;
            }
            Console.WriteLine(HalfDivision(a, b, e));
        }
        public static double HalfDivision(double a, double b, double e)
        {
            while (b - a > 2 * e)
            {
                double c = (a + b) / 2;

                if (Calc(a) * Calc(c) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
            }
            return (a + b) / 2;
        }

        public static double Calc(double x)
        {
            return x + Math.Log(x + 0.5) - 0.5;
        }
    }
}
