
namespace OrderWords
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    //Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter, how many words you want to put in the list: ");
            int n = int.Parse(Console.ReadLine());
            var words = new List<string>();

            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
            }
            words.Sort();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
