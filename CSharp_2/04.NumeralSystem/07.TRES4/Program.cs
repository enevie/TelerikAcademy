using System;
using System.Text;

class Program
{
    static string Convertor(string number)
    {
        long num = Convert.ToInt64(number);
        long currNum = 0;
        StringBuilder result = new StringBuilder();
        char[] saving = new char[64];
        while (num != 0)
        {
            int index = 0;
            currNum = num % 9;
            num = num / 9;
            switch (currNum)
            {
                case 0: result.Append("LON+"); break;
                case 1: result.Append("VK-"); break;
                case 2: result.Append("*ACAD"); break;
                case 3: result.Append("^MIM"); break;
                case 4: result.Append("ERIK|"); break;
                case 5: result.Append("SEY&"); break;
                case 6: result.Append("EMY>>"); break;
                case 7: result.Append("/TEL"); break;
                case 8: result.Append("<<DON"); break;

            }
        }
        
        
        char[] resulting = result.ToString().ToCharArray();
        Array.Reverse(resulting);
        return new string(resulting);

    }


    static void Main(string[] args)
    {
        Console.WriteLine(Convertor("5451"));
    }
}

