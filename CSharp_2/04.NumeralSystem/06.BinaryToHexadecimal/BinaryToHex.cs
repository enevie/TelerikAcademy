using System;
using System.Text;

//Problem 6. binary to hexadecimal
//Write a program to convert binary numbers to hexadecimal numbers (directly).

class BinaryToHex
{
    static StringBuilder BinaryHex(string binaryNumber)
    {

        int[] exactDigit = new int[4];
        char[] digits = binaryNumber.ToCharArray();
        string currNumber = string.Empty;
        StringBuilder result = new StringBuilder();

        int startIndex = 0;
        int coef = 1;
        int anotherCoef = 0;
        int jump = 4;

        for (int i = 0; i < binaryNumber.Length/4; i++)
        {
            for (int j = startIndex; j < jump * coef; j++)
            {
                if (digits[j] == '0')
                {
                    exactDigit[anotherCoef] = 0;
                    anotherCoef++;
                }
                else
                {
                    exactDigit[anotherCoef] = 1;
                    anotherCoef++;
                }
            }
            anotherCoef = 0;
            startIndex += 4;
            coef++;
            currNumber = String.Join("", exactDigit);
            switch (currNumber)
            {
                case "0000": result.Append("0"); break;
                case "0001": result.Append("1"); break;
                case "0010": result.Append("2"); break;
                case "0011": result.Append("3"); break;
                case "0100": result.Append("4"); break;
                case "0101": result.Append("5"); break;
                case "0110": result.Append("6"); break;
                case "0111": result.Append("7"); break;
                case "1000": result.Append("8"); break;
                case "1001": result.Append("9"); break;
                case "1010": result.Append("A"); break;
                case "1011": result.Append("B"); break;
                case "1100": result.Append("C"); break;
                case "1101": result.Append("D"); break;
                case "1110": result.Append("E"); break;
                case "1111": result.Append("F"); break;
            }

        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter binary number: ");
        string binary = Console.ReadLine();
        Console.WriteLine("The digit in hexadecimal is: "+BinaryHex(binary));

    }
}

