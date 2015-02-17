using System;

/*
 * Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
 */

class Program
{
    static void Main()
    {
        Console.Write("Please, enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please, enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        

        if(a>b)
        {
            Console.WriteLine(b+" "+ a);
        }
        else
        {
            Console.WriteLine(a+ " " + b);
        }
    }
}

