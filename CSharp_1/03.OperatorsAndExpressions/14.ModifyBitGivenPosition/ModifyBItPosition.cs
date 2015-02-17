using System;


class ModifyBItPosition
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter the new bit: 0/1 ");
        int newBit = int.Parse(Console.ReadLine());
 
         if (((number >> position)  & 1) != newBit)
        {
            int newNumber = number ^ (1 << position);
            Console.WriteLine(newNumber);
        }
        
}
}

