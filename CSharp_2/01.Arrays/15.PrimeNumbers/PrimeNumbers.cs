

/*
 * Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

 */

﻿using System;
using System.Linq;

class SieveOfEratosthenes
{
    
    static void Sieve(int upTo)
    {
        bool[] notPrime = new bool[upTo];
        notPrime[0] = notPrime[1] = true;

        for (int i = 2; i < Math.Sqrt(notPrime.Length); i++)
        {
            if (!notPrime[i])
            { 
                for (int j = i * 2; j < notPrime.Length; j += i)
                {
                    notPrime[j] = true;
                }
            }
        }
        //Print(notPrime);
    }
    static void Print(bool[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == false)
            {
                Console.Write(i + " ");
            }
        }
    }
    static void Main()
    {
        DateTime first = DateTime.Now;
        Sieve(10000000);
        TimeSpan normalSieveTime = DateTime.Now - first;
        DateTime second = DateTime.Now;
        Console.WriteLine("Sieve with bool: {0}", normalSieveTime);
    }
}