using System;
/*
 * Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
 */

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Greater : {0}", a>b ? a : b);
    }
}

