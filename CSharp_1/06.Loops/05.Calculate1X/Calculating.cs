using System;
using System.Numerics;


/*
 * Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
Use only one loop. Print the result with 5 digits after the decimal point.
 */

class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            decimal sum = 1;

            for (int i = 0; i < n; i++)
            {
                sum += (decimal)(Fact(i))/(decimal)Math.Pow(x,i);
            }
            Console.WriteLine("{0:0.00000}",sum);
        }


           private static BigInteger Fact(int n)
            {
               if(n==0) return 1;
               return n*Fact(n-1);
            }
        }
    


