using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prak5
{
    public class Program
    {
        static Dictionary<string, Func<double, double, double>> operators = new Dictionary<string, Func<double, double, double>>
        {
            { "+", Sum },
            { "-",  Subtraction},
            { "*",  Multiplication},
            { "/",  Division}
        };

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите a: ");
                double a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите b: ");
                double b = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите оператор (+, - , *, /): ");
                string oper = Console.ReadLine();

                Console.WriteLine(operators[oper](a, b));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static double Sum(double a, double b) => a + b;
        public static double Subtraction(double a, double b) => a - b;
        public static double Multiplication(double a, double b) => a * b;
        public static double Division(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }
    }
}
