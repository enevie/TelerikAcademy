using System;

//Write a method that reverses the digits of given decimal number.

class Reverse
{
    static string ReverseNumber(string number)
    {
        char[] reverseResult = number.ToCharArray();
        Array.Reverse(reverseResult);
        return new string(reverseResult);
    }
    static void Main()
    {
        Console.WriteLine("Enter the number you want to reverse: ");
        string number = Console.ReadLine();
        string result = ReverseNumber(number);
        Console.WriteLine(result);
    }
}

