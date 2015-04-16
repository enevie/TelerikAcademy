namespace Classes2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartMain
    {
        public static void Main()
        {
            var point = new Point3D(1, 5, 3);
            var point2 = new Point3D(3, 7, 1);

            Console.WriteLine(point.ToString());
            Console.WriteLine(CalculatingDistance.Calculating(point,point2));

            Path a = new Path();
            a.AddPoint(point);
            a.AddPoint(point2);

            PathStorage.SavePath(a, "firstPath");
        }
    }
}
