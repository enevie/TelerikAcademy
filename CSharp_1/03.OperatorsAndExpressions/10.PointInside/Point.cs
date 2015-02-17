using System;
using System.Linq;

/*Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
* and out of the rectangle R(upper left corner X=1, upper left corner Y=-1, width=6, height=2).
Examples:

x	    y	        inside K & outside of R
1	    2	        yes
2.5	    2	        no
0	    1	        no
2.5	    1	        no
2	    0	        no
4	    0	        no
2.5	    1.5	        no
2	    1.5	        yes
1	    2.5 	    yes
-100	-100	    no
*/



class Point
{

    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        double circleRadius = 1.5;

        bool outRectangle = ((x < -1 || x > 5 || y < -1 || y > 1));
        bool isInCircle = ((x-1) * (x-1)) + (y-1) * (y-1) <= Math.Pow(circleRadius,2);
        bool finalResult = outRectangle && isInCircle;
        Console.WriteLine(finalResult);

    }

}

