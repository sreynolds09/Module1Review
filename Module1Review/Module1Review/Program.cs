using System;

namespace Module1Review
{
    public class Program
    {
        static void Main(string[] args)
        {
            static double CircleArea(double radius)
            {
                return Math.PI * radius * radius;
            }

            double radius = 0;
            Console.WriteLine($"What is the radius of the circle?");
            
            int userInput = int.Parse(Console.ReadLine());
            userInput = (int)(radius + userInput);
            double area = CircleArea(userInput); 
            Console.WriteLine($"The area of the circle with radius {userInput} is: {area}"); 
        }
        
       
    }
}