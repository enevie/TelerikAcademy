using System;

/*
* Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps
*/

class ComapringFloats
{
static void Main()
{
    Console.Write("Enter the first number: ");
    double firstNumber = double.Parse(Console.ReadLine());

    Console.Write("Enter the second number: ");
    double secondNumber = double.Parse(Console.ReadLine());

    double eps = 0.000001;
    bool isEqual = true;

    if (Math.Abs(firstNumber - secondNumber) < eps)
    {
        Console.WriteLine(isEqual);
    }
    else if (Math.Abs(firstNumber - secondNumber) > eps)
    {
        isEqual = false;
        Console.WriteLine(isEqual);
    }
}
}
