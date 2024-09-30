using System;

namespace GeometryLib
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("All sides must be greater than zero.");
            }

            if (!IsValidTriangle(sideA, sideB, sideC))
            {
                throw new ArgumentException("The provided sides do not form a valid triangle.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        // Проверка на корректность треугольника
        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        // Вычисление площади по формуле Герона
        public double GetArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        // Проверка на прямоугольный треугольник
        public bool IsRightTriangle()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
        }
    }
}
