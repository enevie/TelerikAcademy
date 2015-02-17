using System;

//Problem 1. Decimal to binary
//Write a program to convert decimal numbers to their binary representation.

class DecimalToBinary
{
    static int[] ConvertToBinary(int number)
    {
        int[] binaryNumber = new int[32];
        int index = binaryNumber.Length-1;
        while (number != 0)
        {
            binaryNumber[index] = number % 2;
            number = number / 2;
            index--;
        }
        return binaryNumber;
    }
    static void Main()
    {
        Console.WriteLine("Enter a decimal number you want to convert to binary: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The representation of that number in binary is: ");
        Console.WriteLine(String.Join("",ConvertToBinary(n)));
    }
}

