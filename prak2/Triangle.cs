using System;
using System.Collections.Generic;
using System.Text;

namespace Prak2
{
    public class Triangle
    {
        private double[] sides;
        private double area;
        private double perimeter;
        public double Area 
        { 
            get
            {
                return area;
            } 
            set 
            {
                area = value;
            }
        }
        public string AngleType => GetTypeByAngles();
        public string SideType => GetTypeBySides();
        public Triangle(double a, double b, double c)
        {
            if (!((a>0 & b>0 & c>0) & (c<a+b & a<b+c & b<a+c)))
            {
                throw new Exception("Неверные стороны треугольника");
            }

            sides = new double[] { a, b, c };
            perimeter = a + b + c;
            area = Math.Sqrt(perimeter / 2 * ((perimeter) / 2 - a) * ((perimeter) / 2 - b) * ((perimeter) / 2 - c));
        }
        public string GetTypeByAngles()
        {
            string type;
            Array.Sort(sides);
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

            if (sides[0] == sides[1] && sides[1] == sides[2])
            {
                type = "Равносторонний";
            }
            else if (sides[0] == sides[1] && sides[0] != sides[2] || sides[0] == sides[2] && sides[0] != sides[1] || sides[1] == sides[2] && sides[0] != sides[1])
            {
                type = "Равнобедренный";
            }
            else
            {
                type = "Разносторонний";
            }

            return type;
        }


    }
}
