using System;

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the rectangular: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the other side: ");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[m, n];
        int currSum = 0;
        int maxSum = 0;
        Random filling = new Random();
        int[,] result = new int[3, 3];

        //filling the main matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = filling.Next(1, 99);
            }
        }

        //calculating the result
        for (int row = 1; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 1; col < matrix.GetLength(1) - 1; col++)
            {
                currSum += matrix[row - 1, col - 1] + matrix[row - 1, col] + matrix[row - 1, col + 1] +
                           matrix[row, col] + matrix[row, col - 1] + matrix[row, col + 1] +
                           matrix[row + 1, col - 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (currSum > maxSum)
                {
                    //filling the result matrix
                    result[0, 0] = matrix[row - 1, col - 1];
                    result[0, 1] = matrix[row - 1, col];
                    result[0, 2] = matrix[row - 1, col + 1];
                    result[1, 0] = matrix[row, col - 1];
                    result[1, 2] = matrix[row, col + 1];
                    result[1, 1] = matrix[row, col];
                    result[2, 0] = matrix[row + 1, col - 1];
                    result[2, 1] = matrix[row + 1, col];
                    result[2, 2] = matrix[row + 1, col + 1];

                    maxSum = currSum;
                }
                currSum = 0;
            }
        }
        Console.WriteLine();

        //printing the main matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,6}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("The best 3x3 sum is: ");


        //printing the result matrix
        for (int row = 0; row < result.GetLength(0); row++)
        {
            for (int col = 0; col < result.GetLength(1); col++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0,6}", result[row, col]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("The sum of those 3x3 is: " + maxSum);
        Console.ForegroundColor = ConsoleColor.Green;
    }
}

