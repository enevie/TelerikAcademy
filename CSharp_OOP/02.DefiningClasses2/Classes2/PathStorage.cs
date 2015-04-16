using System;
using System.IO;

namespace Classes2
{
    public static class PathStorage
    {
       public static void SavePath(Path path, string pathIndent)
        {
           using (StreamWriter sw = new StreamWriter("..//..//path" + pathIndent + ".txt"))
           {
               for (int i = 0; i < path.PathList.Count; i++)
               {
                   sw.WriteLine(path.PathList[i]);
               }
           }
        }

        public static Path LoadPath(string filePath)
       {
           Path path = new Path();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.EndOfStream == false)
                {
                    string nextPointTxt = reader.ReadLine();
                    Point3D nextPoint = Point3D.Parse(nextPointTxt) ;
                    path.AddPoint(nextPoint);
                }
            }
            return path;
       }


    }
}
