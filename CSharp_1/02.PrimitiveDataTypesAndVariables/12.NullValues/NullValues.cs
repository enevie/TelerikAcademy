using System;

/*
 * Create a program that assigns null values to an integer and to a double variable.
   Try to print these variables at the console.
   Try to add some number or the null literal to these variables and print the result.
 */

class Program
{
    static void Main()
    {
        int? first = null;
        double? second = null;

        Console.WriteLine("Only Nulls: {0} {1}", first, second);

        first += 5;
        second += 10;
        Console.WriteLine("Adding number to null: {0} {1}", first, second);

        first = 5;
        second = 10.3;
        Console.WriteLine("New values: {0}, {1}", first, second);
    }
}

