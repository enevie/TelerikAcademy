using System;

/*
Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
*/



class Program
{
static void Main()
{
    Console.WriteLine(@"choose:
   1--> int
   2--> double
   3--> string");
    int number = int.Parse(Console.ReadLine());

    switch(number)
    {
        case (1):
            Console.WriteLine("Please, enter integer: ");
            int input = int.Parse(Console.ReadLine());
            input += 1;
            Console.WriteLine(input);
            break;

        case(2):
            Console.WriteLine("Please, enter double: ");
            double inputDouble = double.Parse(Console.ReadLine());
            inputDouble++;
            Console.WriteLine(inputDouble);
            break;

        case(3):
            Console.WriteLine("Please, enter string: ");
            string inputString = Console.ReadLine();
            Console.WriteLine(inputString+"*");
            break;

        default:
            Console.WriteLine("invalid input"); break;
    }
}
}
