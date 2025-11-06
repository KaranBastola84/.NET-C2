using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.class2
{
    public class Circle
    {
        public const double PI = 3.14;
        // Method to calculate area of circle
        public double CalculateArea(double radius)
        {
            return PI * radius * radius;
        }
        // Method to calculate perimeter of circle
        public double CalculatePerimeter(double radius)
        {
            return 2 * PI * radius;
        }
    }
}