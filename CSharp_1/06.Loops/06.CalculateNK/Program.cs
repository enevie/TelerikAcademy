using System;
using System.Numerics;

/*Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.?
 */

class Program
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger kFact = 1;


        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
        }

        for (int j = 1; j <= k; j++)
        {
            kFact *= j;
        }
        Console.WriteLine(nFact / kFact);
    }
}

