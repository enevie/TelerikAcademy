using System;

/*
 * Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
 */

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("enter radius: ");
        float radius = float.Parse(Console.ReadLine());
        double area = Math.PI * radius * radius;
        double perimeter = 2 * Math.PI * radius; 
        Console.WriteLine("Circle perimeter: {0:#.##} and Circle Area: {1:#.##}", perimeter,area);
    }
}
