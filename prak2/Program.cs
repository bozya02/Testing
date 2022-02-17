using System;
using System.Collections.Generic;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter side 1: ");
                double s1 = double.Parse(Console.ReadLine());

                Console.Write("Enter side 2: ");
                double s2 = double.Parse(Console.ReadLine());

                Console.Write("Enter side 3: ");
                double s3 = double.Parse(Console.ReadLine());
                
                Triangle triangle = new Triangle(s1, s2, s3);
                Console.WriteLine(triangle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Triangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }

        public Triangle(double s1, double s2, double s3)
        {
            if (!IsTriangle(s1, s2, s3))
                throw new Exception("It's not a triangle");
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }

        public void IsCorrectVariables(double s1, double s2, double s3)
        {
            if (s1 < 0 || s2 < 0 || s3 < 0)
                throw new Exception("One or more sides less 0");
        }

        public bool IsTriangle(double s1, double s2, double s3)
        {
            IsCorrectVariables(s1, s2, s3);
            if (s1 + s2 > s3 && s2 + s3 > s1 && s1 + s3 > s2)
                return true;
            return false;
        }

        public string GetTypeByAngles()
        {
            string type;
            List<double> sides = new List<double>() { side1, side2, side3 };
            sides.Sort();
            double cos = (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) / (2 * sides[0] * sides[1]);

            if (cos < 0)
            {
                type = "Тупоугольный";
            }
            else if (cos > 0)
            {
                type = "Остроугольный";
            }
            else
            {
                type = "Прямоугольный";
            }

            return type;
        }

        public string GetTypeBySides()
        {
            string type;

            if (side1 == side2 && side2 == side3)
            {
                type = "Равносторонний";
            }
            else if (side1 == side2 && side1 != side3 || side1 == side3 && side1 != side2 || side2 == side3 && side1 != side2)
            {
                type = "Равнобедренный";
            }
            else
            {
                type = "Разносторонний";
            }

            return type;
        }

        public double GetArea()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public override string ToString()
        {
            return $"Triangle with sides {side1}, {side2}, {side3}\n" +
                $"Side Type: {GetTypeBySides()}\n" +
                $"Corner Type: {GetTypeByAngles()}\n" +
                $"Area: {GetArea()}";
        }
    }
}
