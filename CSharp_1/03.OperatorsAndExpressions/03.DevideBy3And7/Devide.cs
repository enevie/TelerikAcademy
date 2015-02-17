using System;

/*
 * Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
Examples:

n	Divided by 7 and 5?
3	false
0	false
5	false
7	false
35	true
140	true
 */

class Devide
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(number%5==0 && number%7==0 ? true : false);
    }
}

