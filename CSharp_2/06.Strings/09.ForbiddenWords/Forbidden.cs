namespace ForbiddenWords
{
    using System;
    using System.Text;

    //    We are given a string containing a list of forbidden words and a text containing some of these words.
    //Write a program that replaces the forbidden words with asterisks.
    //Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

    //Forbidden words: PHP, CLR, Microsoft

    //The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.


    class Forbidden
    {
        static void Main()
        {
            string rawText = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            var result = new StringBuilder();

            for (int j = 0; j < rawText.Length; j++)
            {
                result.Append(rawText[j]);
                result.Replace("PHP", "***");
                result.Replace("Microsoft", "*******");
                result.Replace("CLR", "***");
            }
            Console.WriteLine(result.ToString());
        }
    }
}
