namespace GSMInfo
{
    using System;
    class Display
    {
        private int? size;
        private int? numberOfColors;

        public Display()
            : this(null, null)
        {

        }

        public Display(int? numberOfColors)
            : this(null, numberOfColors)
        {

        }

        public Display(int? size, int? numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public int? Size
        {
            get { return this.size; }
            set
            {
                if(value<5 || value>20)
                {
                    throw new ArgumentException("The size must be between 5 and 20 inches!");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public int? NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if(value<255)
                {
                    throw new ArgumentException("The colors must be more thant 255!");
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }

    }
}
