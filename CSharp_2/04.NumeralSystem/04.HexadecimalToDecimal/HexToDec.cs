using System;

//Problem 4. Hexadecimal to decimal
//Write a program to convert hexadecimal numbers to their decimal representation.

class HexaToDecimal
{
    static double HexToDec(string number)
    {
        char[] arr = new char[8];
        double result = 0;
        for (int i = 0; i < number.Length; i++)
        {
            arr[i] = number[i];
        }
        int[] transformedDigits = new int[8];

        for (int i = 0; i < arr.Length; i++)
        {
            switch (arr[i])
            {
                case '0': transformedDigits[i] = 0; break;
                case '1': transformedDigits[i] = 1; break;
                case '2': transformedDigits[i] = 2; break;
                case '3': transformedDigits[i] = 3; break;
                case '4': transformedDigits[i] = 4; break;
                case '5': transformedDigits[i] = 5; break;
                case '6': transformedDigits[i] = 6; break;
                case '7': transformedDigits[i] = 7; break;
                case '8': transformedDigits[i] = 8; break;
                case '9': transformedDigits[i] = 9; break;
                case 'A': transformedDigits[i] = 10; break;
                case 'B': transformedDigits[i] = 11; break;
                case 'C': transformedDigits[i] = 12; break;
                case 'D': transformedDigits[i] = 13; break;
                case 'E': transformedDigits[i] = 14; break;
                case 'F': transformedDigits[i] = 15; break;
            }
        }
        for (int i = 0; i < transformedDigits.Length; i++)
        {
            int index = number.Length-i-1;
            result += transformedDigits[i]*Math.Pow(16,index);
        }
        return result;
    }
   
    static void Main()
    {
        Console.WriteLine("Enter hexadecimal number to convert: ");
        string number = Console.ReadLine();
        int result = (int)HexToDec(number);
        Console.WriteLine("The decimal representation is: "+HexToDec(number));
    }
}
