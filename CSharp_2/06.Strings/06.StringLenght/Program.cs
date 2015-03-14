using System;
using System.Text;

//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled  with *.
//Print the result string into the console.

class Program
{
    static void Main()
    {

        string text = Console.ReadLine();
        while (text.Length > 20)
        {
            Console.WriteLine("Error, the string must be max 20 characters!");
            text = Console.ReadLine();
        }
        char[] newText = new char[20];
        for (int i = 0; i < text.Length; i++)
        {
            newText[i] = text[i];
        }

        for (int i = text.Length; i < newText.Length; i++)
        {
            newText[i] = '*';
        }

        Console.WriteLine(string.Join("", newText));
    }
}

