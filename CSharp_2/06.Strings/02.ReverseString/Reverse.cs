using System;

//Write a program that reads a string, reverses it and prints the result at the console.

class Reverse
{
    static void Main()
    {

        Console.WriteLine("Please enter a word to reverse: ");
        string input = Console.ReadLine();
        char[] reverse = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            reverse[i] = input[i];
        }
        Array.Reverse(reverse);
        Console.WriteLine("reversed: "+String.Join("", reverse));

    }
}

