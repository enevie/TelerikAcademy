using System;

//Problem 2. Binary to decimal
//Write a program to convert binary numbers to their decimal representation

class BinaryToDecimal
{
    static double ConvertToDecimal(string binaryNumber)
    {
        double decimalNumber = 0;
        char[] charBinary = binaryNumber.ToCharArray();
        Array.Reverse(charBinary);
        for (int i = 0; i < charBinary.Length; i++)
        {
            if (charBinary[i] == '1')
            {
                decimalNumber += Math.Pow(2, i);
            }
        }
        return decimalNumber;
    }

    static void Main()
    {
        Console.WriteLine("Enter a binary number: ");
        string binary = Console.ReadLine();
        Console.WriteLine("Your decimal number is: "+ConvertToDecimal(binary));
    }
}

