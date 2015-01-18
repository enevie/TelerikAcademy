using System;
/*
 * Write an expression that extracts from given integer n the value of given bit at index p.
 */

class BitFromInteger
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the position you want: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine((n>>p) & 1);
    }
}
