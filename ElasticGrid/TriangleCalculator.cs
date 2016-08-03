using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticGrid
{
    public static class TriangleCalculator
    {
        public static double Calculate(double a, double b, double c)
        {
            if(IsValidTriangle(a, b, c))
            {
                var p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }

            throw new InvalidTriangleException();
        }

        private static bool IsValidTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
        }

        public static double CalculateRightAngleTriangle(double a, double b)
        {
            if (IsValidRightAngleTriangle(a, b))
            {
                return a * b / 2;
            }

            throw new InvalidTriangleException();
        }

        private static bool IsValidRightAngleTriangle(double a, double b)
        {
            return a > 0 && b > 0;
        }
    }
}
