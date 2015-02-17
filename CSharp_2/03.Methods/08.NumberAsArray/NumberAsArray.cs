using System;
using System.Numerics;

//Write a method that adds two positive stringeger numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

class NumberAsArray
{
    static string NumbersAsArrays(string numberFirst, string numberSecond)
    {
        
        BigInteger sum = 0;
        BigInteger coef = 1;
        if (numberFirst.Length != numberSecond.Length)
        {
            int arrayDiff = Math.Abs(numberFirst.Length - numberSecond.Length)+1;
            if (numberFirst.Length > numberSecond.Length)
            {
                numberSecond = numberSecond.PadLeft(arrayDiff, '0');
            }
            else
            {
                numberFirst = numberFirst.PadLeft(arrayDiff, '0');
            }
        }

        for (int i = numberFirst.Length-1; i >= 0; i--)
        {
            if (coef == 1) sum += numberFirst[i]-'0' + numberSecond[i]-'0';
            else sum += (numberFirst[i] - '0' + numberSecond[i] - '0') * coef;
            coef *= 10;
        }
        return sum.ToString();
    }

    static void Main()
    {
        Console.WriteLine("Please enter the first number: ");
        string firstNumber = Console.ReadLine();
        Console.WriteLine("Please enter the second number: ");
        string secondNumber = Console.ReadLine();
        Console.WriteLine("The sum of these numbers is:" + NumbersAsArrays(firstNumber, secondNumber));

    }
}

