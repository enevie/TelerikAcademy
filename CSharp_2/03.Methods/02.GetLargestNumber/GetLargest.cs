using System;

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

class GetLargest
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        //compare two numbers with the method
        int maxNumber = GetMax(firstNumber, secondNumber);

        //compare the result of the method with other digit out from the method
        if (maxNumber < thirdNumber)
        {
            Console.WriteLine("The largest number is: "+thirdNumber);
        }
        else if(maxNumber==thirdNumber)
        {
            Console.WriteLine("There are two equal largest numbers:" +maxNumber);
        }
        else
        {
            Console.WriteLine("The largest number is: "+maxNumber);
        }
    }
}


