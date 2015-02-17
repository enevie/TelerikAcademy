using System;
//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix
class SequenceInMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter how many rows in the matrix; ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter how many cols in the matrix:");
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        int counter = 0;
        int maxCounter = 0;
        string element = "";

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.WriteLine("enter the [{0}] [{1}] index of the matrix", row, col);
                matrix[row, col] = Console.ReadLine();
            }
       } 

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            counter = 1;
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    element = matrix[row, col];
                }
            }
            counter = 1;
        }

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            counter = 1;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    element = matrix[row, col];
                }
            }
            counter = 1;
        }

        for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
        {
            if (matrix[row, col] == matrix[row + 1, col + 1])
            {
                counter++;
            }
            else
            {
                counter = 1;
            }

            if (counter > maxCounter)
            {
                maxCounter = counter;
                element = matrix[row, col];
            }
        }
        Console.WriteLine("{0} x ({1}) times",element,maxCounter);
    }
}


