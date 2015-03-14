using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        string number = Console.ReadLine();

        var test = new StringBuilder();
        var backNumbers = new List<string>();
        int startIndex = 0;
        long result = 0;

        for (int j = startIndex; j < number.Length; j++)
        {
            test.Append(number[j]);
            switch (test.ToString())
            {
                case "f": backNumbers.Add("f"); startIndex = j + 1; test.Clear(); break;
                case "bIN": backNumbers.Add("bIN"); startIndex = j + 1; test.Clear(); break;
                case "oBJEC": backNumbers.Add("oBJEC"); startIndex = j + 1; test.Clear(); break;
                case "mNTRAVL": backNumbers.Add("mNTRAVL"); startIndex = j + 1; test.Clear(); break;
                case "lPVKNQ": backNumbers.Add("lPVKNQ"); startIndex = j + 1; test.Clear(); break;
                case "pNWE": backNumbers.Add("pNWE"); startIndex = j + 1; test.Clear(); break;
                case "hT": backNumbers.Add("hT"); startIndex = j + 1; test.Clear(); break;
            }
        }

        int multiply = 0;
        for (int i = backNumbers.Count - 1; i >= 0; i--)
        {
            switch (backNumbers[i])
            {
                case "f": result += 0; multiply++; break;
                case "bIN": result += 1 * (long)Math.Pow(7, multiply); multiply++; break;
                case "oBJEC": result += 2 * (long)Math.Pow(7, multiply); multiply++; break;
                case "mNTRAVL": result += 3 * (long)Math.Pow(7, multiply); multiply++; break;
                case "lPVKNQ": result += 4 * (long)Math.Pow(7, multiply); multiply++; break;
                case "pNWE": result += 5 * (long)Math.Pow(7, multiply); multiply++; break;
                case "hT": result += 6 * (long)Math.Pow(7, multiply); multiply++; break;
            }
        }
        Console.WriteLine(result);
    }
}



