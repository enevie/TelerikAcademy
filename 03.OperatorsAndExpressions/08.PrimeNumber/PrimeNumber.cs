using System;

/*
* Write an expression that checks if given positive integer number n (n = 100) is prime 
* (i.e. it is divisible without remainder only to itself and 1).
Examples:

n	Prime?
1	false
2	true
3	true
4	false
9	false
97	true
51	false
-3	false
0	false
*/

class PrimeNumber
{
static void Main()
{
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine(isPrime(number));
}

private static bool isPrime(int number)
{
    if (number < 0) return false;
    if (number == 2)  return true; 
    if (number % 2 == 0) return false;

    for (int i = 3; i*i  <= number; i+=2)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
    }
}
    

   






