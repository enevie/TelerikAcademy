﻿using System;

/*
* Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
*/


class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i <= number; i++)
        {
            if(i%3!=0 && i%7!=0)
            {
                Console.Write(i+ " ");
            }   
        }
    }
}
