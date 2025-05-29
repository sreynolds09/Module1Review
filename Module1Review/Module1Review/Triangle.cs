using System;

namespace Module1Review
{
    public class Triangle
    {
            public double CalculateTriangleArea(double baseLength, double height)
            {
                return (baseLength * height) / 2;
            }
            static void Main(string[] args)
            {
                double baseLength = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Triangle triangle = new Triangle();
                Console.WriteLine(triangle.CalculateTriangleArea(baseLength, height));
                

            }
    }
}