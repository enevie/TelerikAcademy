using System;

/*
 * Write an expression that calculates rectangle’s perimeter and area by given width and height.
Examples:

width	height	perimeter	area
3	       4	 14	          12
2.5	       3	 11	         7.5
5	       5	 20	         25
 */

class Program
{
    static void Main()
    {
        Console.Write("Enter rectangle width: ");
        float width = float.Parse(Console.ReadLine());
        Console.Write("Enter rectangle height: ");
        float height = float.Parse(Console.ReadLine());

        float areа = width * height;
        float perimetar = 2 * width + 2 * height;
        Console.WriteLine("Area :" + areа);
        Console.WriteLine("Perimetar :" + perimetar);
    }
}

