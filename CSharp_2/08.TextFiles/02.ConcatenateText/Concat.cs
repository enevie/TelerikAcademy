namespace ConcatenateText
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;


    class Concat
    {
        static void Main()
        {
            Results(600111110);
        }

        private static void Results(int currSum)
        {
            var reader = new StreamReader("result.txt");

            string[] rawResults = reader.ReadToEnd().Split('\n');
            int[] results = new int[rawResults.Length];

            for (int i = 0; i < results.Length; i++)
            {
                if (rawResults[i] == string.Empty)
                {
                    continue;
                }
                results[i] = int.Parse(rawResults[i]);
            }
            Array.Sort(results);
            Array.Reverse(results);
            reader.Close();

            var writer = new StreamWriter("result.txt", true);
            int bestSum = results[0];

            if (currSum == bestSum)
            {
                Console.WriteLine("Your are equal to BEST BATKA!");
            }
            else if (currSum > bestSum)
            {
                using (writer)
                {
                    Console.WriteLine("GOOD BATKAAA! New high score! {0} points", currSum);
                    writer.WriteLine(currSum);
                }
            }
            else
            {
                Console.WriteLine("Your result is " + currSum);
            }
        }
    }
}
