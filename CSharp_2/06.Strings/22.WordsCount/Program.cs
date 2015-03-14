namespace WordsCount
{
    using System;
    using System.Text;
    using System.Linq;



    class Program
    {
        static void Main(string[] args)
        {

            string text = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";
            text.ToLower();
            var letters = new char[26];
            var counters = new int[26];
            int counter = 0;
            for (int i = 'a'; i <= 'z'; i++, counter++)
            {
                letters[counter] = (char)i;
            }
            for (int i = 0; i < text.Length; i++)
            {
                 if(letters.Contains(text[i]))
                 {
                     counters[i] += 1;
                 }
            }


        }
    }
}
