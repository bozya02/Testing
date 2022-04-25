using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static Dictionary<string, Func<double, double, double>> Operators = new Dictionary<string, Func<double, double, double>>()
        {
            {"+", Sum },
            {"-", Substract},
            {"*", Multiple },
            {"/", Divide }
        };
        static void Main(string[] args)
        {
            try
            {
                var input = Console.ReadLine().Split(' ');
                var a = Convert.ToDouble(input[0]);
                var b = Convert.ToDouble(input[2]);
                var operation = input[1];
                Console.WriteLine(Operators[operation](a, b));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }
        public static double Multiple(double a, double b)
        {
            return a * b;
        }
        public static double Substract(double a, double b)
        {
            return a - b;
        }
    }
}
