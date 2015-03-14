using System;
using System.Collections.Generic;
using System.Text;

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is in

//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9


class Program
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        int index = 0;
        int nextIndex = 0;
        var result = new List<int>();

        for (int i = 0; i < text.Length; i++)
        {
            index = text.IndexOf("in", nextIndex);
            nextIndex = index+1;
            if(index < 0)
            {
                break;
            }
            result.Add(index);
        }
        Console.WriteLine(result.Count);
    }
}
