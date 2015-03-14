using System;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

class Breckets
{
    static void Main(string[] args)
    {

        string expression = Console.ReadLine();
        int openingBrackets = 0;
        int closingBrackets = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if(expression[i].Equals('('))
            {
                openingBrackets++;
            }
            if (expression[i].Equals(')'))
            {
                closingBrackets++;
            }
        }
        if(openingBrackets==closingBrackets)
        {
            Console.WriteLine("correct expression!");
        }
        else
        {
            Console.WriteLine("incorrect expression!");
        }
    }
}

