﻿using System;

/*
 * Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.
 */



class TheMatrix
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(i+j);
            }
            Console.WriteLine();
        }
    }
}

