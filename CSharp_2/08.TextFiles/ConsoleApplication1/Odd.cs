namespace OddLines
{
    using System;
    using System.IO;

    class OddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("test.txt");

            using (reader)
            {
                string[] result = reader.ReadToEnd().Split('\n');

                for (int i = 0; i < result.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(result[i]);
                    }
                    if (result[0] == string.Empty)
                    {
                        Console.WriteLine("There is no text!");
                    }
                }
            }
        }
    }
}
