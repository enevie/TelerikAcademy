using System;
using System.Text;

//Problem 5. Hexadecimal to binary
//Write a program to convert hexadecimal numbers to binary numbers (directly).


class HexToBinary
{
    static string ConvertToBinary(string number)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < number.Length; i++)
        {
            switch (number[i])
            {
                case '0': result.Append("0000").Append(' '); break;
                case '1': result.Append("0001").Append(' '); break;
                case '2': result.Append("0010").Append(' '); break;
                case '3': result.Append("0011").Append(' '); break;
                case '4': result.Append("0100").Append(' '); break;
                case '5': result.Append("0101").Append(' '); break;
                case '6': result.Append("0110").Append(' '); break;
                case '7': result.Append("0111").Append(' '); break;
                case '8': result.Append("1000").Append(' '); break;
                case '9': result.Append("1001").Append(' '); break;
                case 'A': result.Append("1010").Append(' '); break;
                case 'B': result.Append("1011").Append(' '); break;
                case 'C': result.Append("1100").Append(' '); break;
                case 'D': result.Append("1110").Append(' '); break;
                case 'E': result.Append("1110").Append(' '); break;
                case 'F': result.Append("1111").Append(' '); break;
            }
        }
        return result.ToString();
    }

    static void Main()
    {
        Console.WriteLine("Enter hexadecimal number: ");
        string number = Console.ReadLine();
        Console.WriteLine("The binary representation is: " +ConvertToBinary(number));
    }
}

