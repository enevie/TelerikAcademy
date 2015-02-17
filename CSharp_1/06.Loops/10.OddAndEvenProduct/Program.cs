using System;

/*
 * 
 You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
 */


class Program
{
    static void Main()
    {
        string[] n = Console.ReadLine().Split(' ');

        int oddSum = 1;
        int evenSum = 1;

        for (int i = 0; i <= n.Length - 1; i++)
        {
            if (i % 2 == 0)
            {
                oddSum *= Convert.ToInt32(n[i]);
            }
            else
            {
                evenSum *= Convert.ToInt32(n[i]);
            }
        }
        if (oddSum == evenSum)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product= " + oddSum);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product="+oddSum);
            Console.WriteLine("even_product="+evenSum);
        }

    }
}

