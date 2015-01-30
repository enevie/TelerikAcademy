using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger nkFact = 1;
        BigInteger razlika = n - k;


        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
        }
        for (int j = 1; j <= k; j++)
        {
            kFact *= j;
        }
        for (int i = 1; i <= razlika; i++)
        {
            nkFact *= i;
        }

        Console.WriteLine(nFact / (kFact * nkFact));
    }
}


