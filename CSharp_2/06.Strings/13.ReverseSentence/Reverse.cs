namespace ReverseSentence
{
    using System;
    using System.Text;

    //Write a program that reverses the words in given sentence.

    class Reverse
    {
        static void Main()
        {
            string rawText = "C# is not C++, not PHP and not Delphi!";
            string[] words = rawText.Split(new char[] {' ', ',','!'},StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            Console.WriteLine(String.Join(" ",words)+"!");
         }
    }
}
