using System;
using System.Collections.Generic;

class PHP
{
    static void Main(string[] args)
    {

        string input = Console.ReadLine();
        List<string> variables = new List<string>();
        int dollarCounter = 0;

        
        for (int i = 0; i < input.Length; i++)
        {
            if(input[i] =='?')
            {
                
            }
            for (int j = 0; j < input.Length; j++)
            {
                if(input[j]=='$')
                {
                    dollarCounter++;
                }
                if(input[j]=='/' || input[j]=='"')
                {
                    break;
                }
                
            }
        }
    }
}

