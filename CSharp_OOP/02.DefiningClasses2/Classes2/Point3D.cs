namespace Classes2
{
    using System;
    using System.Text;

    public struct Point3D
    {
        private static readonly Point3D o; //problem 2
        private double x; //problem 1
        private double y; //problem 1
        private double z; //problem 1

        public static Point3D O //problem 2
        {
            get { return o; }
        }

        static Point3D() //problem 2
        {
            o = new Point3D(0, 0, 0);
        }

        public double X // problem 1
        {
            get { return this.x; }
            private set { this.x = value; }
        }

        public double Y //problem 1
        {
            get { return this.y; }
            private set { this.y = value; }
        }

        public double Z //problem 1
        {
            get { return this.z; }
            private set { this.z = value; }
        }

        public Point3D(double xCoord, double yCoord, double zCoord) //problem 1
        {
            this.x = xCoord;
            this.y = yCoord;
            this.z = zCoord;
        }

        public override string ToString() //problem 1
        {
            string result = string.Format("The point is with coords: x: {0} y: {1} z: {2}", this.X, this.Y, this.Z);
            return result;
        }

        internal static Point3D Parse(string input)
        {
            StringBuilder coordinates = new StringBuilder();
            double[] xyz = new double[3];
            int xyzIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == '-')
                {
                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '-' || input[i] == '.'))
                    {
                        coordinates.Append(input[i]);
                        i++;
                    }
                }

                if (coordinates.Length > 0)
                {
                    double coord = double.Parse(coordinates.ToString());
                    xyz[xyzIndex] = coord;
                    xyzIndex++;
                    coordinates.Clear();
                }
            }

            return new Point3D(xyz[0], xyz[1], xyz[2]);
        }
    }
}
