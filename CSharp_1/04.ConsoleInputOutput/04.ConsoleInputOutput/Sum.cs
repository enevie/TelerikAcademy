using System;

/*
 * Write a program that reads 3 real numbers from the console and prints their sum
 */

class Sum
{
    static void Main(string[] args)
    {
        Console.Write("enter, first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("enter, second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("enter, third number: ");
        int c = int.Parse(Console.ReadLine());
        int sum = a + b + c;
        Console.WriteLine("The sum is: "+sum);
    }
}

