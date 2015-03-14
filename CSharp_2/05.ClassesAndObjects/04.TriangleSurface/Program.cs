using System;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

class Program
{
    static double TriangleSurface(int side, int altitude)
    {
        double result = 0;
        result = (side * altitude) / 2;
        return result;
    }
    static double TriangleSurface(int firstSide, int secondSide, int thirdSide)
    {
        double result = 0;
        double semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
        result = Math.Sqrt(semiPerimeter*(semiPerimeter - firstSide) * (semiPerimeter - secondSide) * (semiPerimeter - thirdSide));
        return result;
    }
    static double TriangleSurface(int firstSide, int secondSide, double angle)
    {
        double result = 0;
        result = (firstSide * secondSide * Math.Sin(angle)) / 2;
        return result;
    }
    

    static void Main()
    {
        double resultWithAngle = TriangleSurface(5,7,45.00);
        Console.WriteLine("{0:F2}",resultWithAngle);

        double resultWithThreeSides = TriangleSurface(8, 9, 11);
        Console.WriteLine("{0:F2}",resultWithThreeSides);

        double resultWithAltitude = TriangleSurface(14, 10);
        Console.WriteLine("{0:F2}",resultWithAltitude);
    }
}

