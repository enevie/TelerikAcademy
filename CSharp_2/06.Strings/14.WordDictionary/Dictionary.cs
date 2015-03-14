
namespace WordDictionary
{
    using System;
    using System.Text;
    using System.Collections.Generic;


    //A dictionary is stored as a sequence of text lines containing words and their explanations.
    //Write a program that enters a word and translates it by using the dictionary.
    //Sample dictionary:

    //input	output
    //.NET	        platform for applications from Microsoft
    //CLR	        managed execution environment for .NET
    //namespace 	hierarchical organization of classes

    class Dictionary
    {
        static void Main()
        {
            var dict = new Dictionary<string,string>();
            dict.Add(".NET", "platform for applications from Microsoft");
            dict.Add("CLR", "managed execution environment for .NET");
            dict.Add("namespace", "hierarchical organization of classes");
            Console.WriteLine("please, enter a word between .NET,CLR,namespace");
            string input = Console.ReadLine();
            Console.WriteLine("The meaning of the word is: "+dict[input]);
        }
    }
}
