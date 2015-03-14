namespace UnicodeCharacter
{
    using System;
    using System.Text;

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:

//input	output
//Hi!	\u0048\u0069\u0021

    class Unicode
    {
        static void Main()
        {
            string rawText = "Hi!";
            string result = string.Empty;
            
            for (int i = 0; i < rawText.Length; i++)
            {
                result += "\\u" + ((int)rawText[i]).ToString("X4");
            }
            Console.WriteLine(result);
        }
    }
}
