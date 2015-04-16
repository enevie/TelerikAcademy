namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
       public static void Main()
        {
            var figures = new List<Shape>()
            {
                    new Triangle(5, 3),
                    new Rectangle(5, 3),
                    new Square(8)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.CalculateSurface() + "      " + figure.GetType());
            }
        }
    }
}
