using System;
using System.Numerics;

/*
 * In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (1 < n < 100).
 */


class Catalan
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger catalan = 0;
        BigInteger nFact = 1;
        BigInteger twoNFact = 1;
        BigInteger nPlusOneFact = 1;

        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
        }
        for (int j = 1; j <= 2 * n; j++)
        {
            twoNFact *= j;
        }
        for (int i = 1; i <= n + 1; i++)
        {
            nPlusOneFact *= i;
        }

        catalan = twoNFact / (nFact * nPlusOneFact);
        Console.WriteLine(catalan);

    }
}

