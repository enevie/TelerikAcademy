using System;

/*
Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange.
*/

class ExchangeVariable
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before Exchange: ");
        Console.WriteLine("int a: {0}, int b: {1}\n", a, b);

        a ^= b;
        b ^= a;
        a ^= b;

        Console.WriteLine("After Exchange: ");
        Console.WriteLine("int a: {0}, int b: {1}\n", a, b);
        
    }
}
