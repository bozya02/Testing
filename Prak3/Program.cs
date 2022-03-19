using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prak3
{
    class Program
    {
        static int Main(string[] args)
        {
            double a = 1;
            double b = 2;
            double c = 3;
            try 
            {
                 a = Convert.ToDouble(Console.ReadLine());
                 b = Convert.ToDouble(Console.ReadLine());
                 c = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели не число");
                return 0;
            }

            try
            {
                AlgebraicEquation algebraic = new AlgebraicEquation(a, b, c);
                Console.WriteLine(algebraic.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
        }
    }

    public class AlgebraicEquation
    {
        private double a;

        public double A
        {
            get { return a; }
            set {
                if (value != 0)
                    a = value;
                else
                    throw new Exception("a value is zero");

                }
        }

        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }


        private double c;

        public double C
        {
            get { return c; }
            set { c = value; }
        }


        public AlgebraicEquation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        private double GetDiscriminant()
        {
            return b * b - 4 * a * c;
        }

        private double GetX1()
        {
            return (-b + Math.Sqrt(GetDiscriminant())) / (2 * a);
        }

        private double GetX2()
        {
            return (-b - Math.Sqrt(GetDiscriminant())) / (2 * a);
        }

        public override string ToString()
        {
            if(GetDiscriminant() >= 0)
                return $"X1: {GetX1()}, X2: {GetX2()}";
            return $"Discriminant is less then zero: {GetDiscriminant()}";
        }
    }
}
