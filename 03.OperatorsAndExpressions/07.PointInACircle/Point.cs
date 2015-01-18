using System;

/*
 * Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
Examples:

x	    y	       inside
-2	    0	        true
-1	    2	        false
1.5	    -1	        true
0	    1	        true
-1.5	-1.5	    false
100	    -30	        false
0	    0	         true
0.2	    -0.8	    true
0.9	    -1.93	    false
1	    1.655	    true
 */


class Point
{
    static void Main()
    {
        Console.Write("Please, enter x: ");
        float x = float.Parse(Console.ReadLine());
        Console.Write("Please, enter y: ");
        float y = float.Parse(Console.ReadLine());
        float c = 2;

        Console.WriteLine(x*x+y*y<=c*c ? true:false);

    }
}

