namespace _01.Shapes
{
    using System;
    
    public class Rectangle : Shape
    {
        public Rectangle(int initialWidth, int initialHeight)
            : base(initialWidth, initialHeight)
        {
        }

        public override int CalculateSurface()
        {
            int surface = this.Height * this.Width;
            return surface;
        }
    }
}
