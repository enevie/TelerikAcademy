namespace _01.Shapes
{
    using System;

    public class Triangle : Shape
    {
        public Triangle(int initialWidth, int initialHeight)
            : base(initialWidth, initialHeight)
        {
        }

        public override int CalculateSurface()
        {
            int surface = (this.Height * this.Width) / 2;

            return surface;
        }
    }
}
