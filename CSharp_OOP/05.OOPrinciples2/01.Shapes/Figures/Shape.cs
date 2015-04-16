namespace _01.Shapes
{
    using System;

    public abstract class Shape
    {
        private int width;
        private int height;

        public Shape(int initialWidth, int initialHeight)
        {
            this.Width = initialWidth;
            this.Height = initialHeight;
        }

        public int Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The width must be >0");
                }

                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The height must be > 0 !");
                }

                this.height = value;
            }
        }

        public abstract int CalculateSurface();
    }
}
