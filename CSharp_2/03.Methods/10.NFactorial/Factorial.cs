using System;
using System.Numerics;

//Write a program to calculate n! for each n in the range [1..100].K

class Factorial
{
    static BigInteger FindFacturial(BigInteger number)
    {
        BigInteger factorial = 1;
        for (int i = 0; i < number; i++)
        {
                factorial *= number - i;
        }
        return factorial;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number to find !number: ");
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine("The factorial of {0} is {1}",number,FindFacturial(number));
    }
}

