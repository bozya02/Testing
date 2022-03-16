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
                if (e < 0)
                    throw new Exception("fault must be greater than 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine(HalfDivision(a, b, e));
        }
        public static double HalfDivision(double a, double b, double e)
        {
            while (b - a >  e)
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
