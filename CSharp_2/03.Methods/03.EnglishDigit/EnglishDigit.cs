using System;

//Write a method that returns the last digit of given integer as an English word.

class Program
{
    static string ReturnEnglishWord(string number)
    {
        string output = string.Empty;
        string lastNumber = number[number.Length - 1].ToString();
        switch (lastNumber)
        {
            case "1": output = "one"; break;
            case "2": output = "two"; break;
            case "3": output = "three"; break;
            case "4": output = "four"; break;
            case "5": output = "five"; break;
            case "6": output = "six"; break;
            case "7": output = "seven"; break;
            case "8": output = "eight"; break;
            case "9": output = "nine"; break;
            case "0": output = "zero"; break;

        }
        return output;
    }

    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        string number = Console.ReadLine();
        string result = ReturnEnglishWord(number);
        Console.WriteLine("The last number with word is: "+result);
    }
}
