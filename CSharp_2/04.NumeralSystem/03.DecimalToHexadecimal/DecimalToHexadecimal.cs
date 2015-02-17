using System;
using System.Text;

class DecimalToHexadecimal
{
    static string ConvertToHexa(int number)
    {
        StringBuilder result = new StringBuilder();
        int[] hexa = new int[8];
        int index = 0;

        while (number != 0)
        {
            hexa[index] = number % 16;
            number = number / 16;
            ++index;
        }
        Array.Reverse(hexa);

        for (int i = 0; i < hexa.Length; i++)
        {
            switch (hexa[i])
            {
                case 0: result.Append(0); break;
                case 1: result.Append(1); break;
                case 2: result.Append(2); break;
                case 3: result.Append(3); break;
                case 4: result.Append(4); break;
                case 5: result.Append(5); break;
                case 6: result.Append(6); break;
                case 7: result.Append(7); break;
                case 8: result.Append(8); break;
                case 9: result.Append(9); break;
                case 10: result.Append("A"); break;
                case 11: result.Append("B"); break;
                case 12: result.Append("C"); break;
                case 13: result.Append("D"); break;
                case 14: result.Append("E"); break;
                case 15: result.Append("F"); break;
            }
        }
        
        return result.ToString();
    }

    static void Main()
    {
        Console.WriteLine("Please, enter a number to convert to hexadecimal: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The converted number is: " + ConvertToHexa(number));
    }
}

