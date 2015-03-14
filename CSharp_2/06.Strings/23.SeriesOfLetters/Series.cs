namespace SeriesOfLetters
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    //Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.


    class Program
    {
        static void Main(string[] args)
        {

            string text = "aaaaabbbbbcdddeeeedssaa";
            var result = new List<char>();
            result.Add(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if(text[i-1]==text[i])
                {
                    continue;
                }
                else
                {
                    result.Add(text[i]);
                }
            }
            Console.WriteLine(String.Join("",result));
        }
    }
}
