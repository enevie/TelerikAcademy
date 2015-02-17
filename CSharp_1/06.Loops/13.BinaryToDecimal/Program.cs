using System;

class Program
{
    static void Main()
    {
        string binary = Console.ReadLine();

        int result = 0;
        for (int bit = 0; bit < binary.Length; bit++)
        {
            result *= 2;
            result += int.Parse(binary[bit].ToString());
        }
        Console.WriteLine(result);

    }
}

