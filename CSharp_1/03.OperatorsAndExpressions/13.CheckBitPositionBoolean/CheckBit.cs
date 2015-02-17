using System;

/*
* Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
*/


class CheckBit
{
static void Main()
{
    Console.Write("Enter number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Enter position: ");
    int position = int.Parse(Console.ReadLine());
    bool test = false;
    int lastBinary = ((number >> position) & 1);

    if(lastBinary==1)
    {
        test = true;
    }
    Console.WriteLine(test);
}
}

