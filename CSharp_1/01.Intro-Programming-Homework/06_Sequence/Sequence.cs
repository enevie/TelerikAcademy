﻿using System;

/*
* Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
*/

class Sequence
{
static void Main()
{
    for (int i = 2; i <= 11; i++)
    {
        if (i % 2 == 1)
        {
            Console.WriteLine(-i);
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}
}
