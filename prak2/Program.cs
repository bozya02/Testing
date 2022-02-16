using System;

namespace Prak2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var c = double.Parse(Console.ReadLine());
                var triangle = new Triangle(a, b, c);
                Console.WriteLine(triangle.AngleType);
                Console.WriteLine(triangle.Area);
                Console.WriteLine(triangle.SideType);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
