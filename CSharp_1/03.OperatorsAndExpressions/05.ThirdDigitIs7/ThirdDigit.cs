using System;

/*
* Write an expression that checks for given integer if its third digit from right-to-left is 7.
Examples:

n	Third digit 7?
5	     false
701	     true
9703	 true
877	     false
777877	 false
9999799	 true
*/


class ThirdDigit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine((number/100)%10 == 7 ? true : false);

    }
}

