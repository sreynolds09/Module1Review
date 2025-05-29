using System;
using Module1Review;

//Area of a Circle
static double CircleArea(double radius)
{
    return Math.PI * radius * radius;
}
//Area of a Triangle
double CalculateTriangleArea(double baseLength, double height)
{
    return (baseLength * height) / 2;
}
//Area of a Square
double CalculateSquareArea(double sideLength)
{
    return sideLength * sideLength;
}

//Area of Rectangle
double CalculateRectangleArea(double length, double width)
{
    return length * width;
}
double radius = 0;
Console.WriteLine($"What is the radius of the circle?");
            
int circleInput = int.Parse(Console.ReadLine());
circleInput = (int)(radius + circleInput);
double area = CircleArea(circleInput); 
Console.WriteLine($"The area of the circle with radius {circleInput} is: {area}");

Console.WriteLine("What is the height of the triangle?");
double height = 0;
int triangleInputOne = int.Parse(Console.ReadLine());
triangleInputOne = (int)(height + triangleInputOne);
Console.WriteLine("What is the Base Length of the triangle?");

int triangleInputTwo = int.Parse(Console.ReadLine());
double baseLength = 0;
triangleInputTwo = (int)(baseLength + triangleInputTwo);
baseLength = CalculateTriangleArea(baseLength, triangleInputTwo);
Console.WriteLine($"The area of the triangle with a height of {triangleInputOne} and a base of {triangleInputTwo} is {CalculateTriangleArea(triangleInputTwo, triangleInputOne)}); ");

Console.WriteLine("What is the length of the side of the square?");
int squareInputOne = int.Parse(Console.ReadLine());
double sideLength = 0;
sideLength = (int)(squareInputOne + sideLength);
sideLength = CalculateSquareArea(sideLength);
Console.WriteLine($"The area of the square is {CalculateSquareArea(squareInputOne)} ");

Console.WriteLine("What is the length of the rectangle?");
int rectangleInputOne = int.Parse(Console.ReadLine());
double rectangleHeight = 0;
rectangleHeight = (int)(rectangleInputOne + rectangleHeight);
Console.WriteLine("What is the width of the rectangle?");
int rectangleInputTwo = int.Parse(Console.ReadLine());
double rectangleWidth = 0;
rectangleWidth = (int)(rectangleInputOne + rectangleWidth);
rectangleWidth = CalculateSquareArea(rectangleWidth);
Console.WriteLine($"The area of the rectangle is {rectangleWidth} ");