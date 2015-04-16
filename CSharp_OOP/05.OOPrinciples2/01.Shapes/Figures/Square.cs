namespace _01.Shapes
{
    using System;
    
    public class Square : Shape
    {
        public Square(int initialHeight)
            : base(initialHeight, initialHeight)
        {
        }

        public override int CalculateSurface()
        {
            return this.Height * this.Height;
        }
    }
}
