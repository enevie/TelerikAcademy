using System;

/*
 * Write an expression that checks if given integer is odd or even.
Examples:

n	Odd?
3	true
2	false
-2	false
-1	true
0	false
 */

class OddOrEven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(number%2==1 || number%2==-1 ? true : false);
    }
}

