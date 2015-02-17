using System;
//Write a program that fills and prints a matrix of size (n, n) as shown 

class FillTheMatrix
{
    static void Main()
    {

        int fillCounter = MatrixA();
        fillCounter = MatrixB(fillCounter);
        int[,] matrixC = MatrixC();
        PrintingMatrix(matrixC);
        Console.WriteLine();
        matrixD();
    }

    private static int[,] MatrixC()
    {
        int value = 0;
        int[,] matrixC = new int[4, 4];
        for (int row = matrixC.GetLength(0) - 1; row >= 0; row--)
        {
            int rows = row;
            int cols = 0;
            while (rows < matrixC.GetLength(0) && cols < matrixC.GetLength(1))
            {
                matrixC[rows++, cols++] = value++;
            }
        }
        for (int col = 1; col < matrixC.GetLength(1); col++)
        {
            int rows = 0;
            int cols = col;
            while (rows < matrixC.GetLength(0) && cols < matrixC.GetLength(1))
            {
                matrixC[rows++, cols++] = value++;
            }
        }
        return matrixC;
    }

    private static int MatrixA()
    {
        int fillCounter = 1;
        int[,] matrix = new int[4, 4];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[col, row] = fillCounter;
                fillCounter++;
            }
        }
        PrintingMatrix(matrix);
        fillCounter = 1;
        Console.WriteLine();
        return fillCounter;
    }

    private static int MatrixB(int fillCounter)
    {
        int[,] matrixB = new int[4, 4];
        for (int col = 0; col < matrixB.GetLength(0); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrixB.GetLength(0); row++)
                {
                    matrixB[row, col] = fillCounter;
                    fillCounter++;
                }
            }
            else
            {
                for (int row = matrixB.GetLength(0) - 1; row >= 0; row--)
                {
                    matrixB[row, col] = fillCounter;
                    fillCounter++;
                }
            }
        }
        PrintingMatrix(matrixB);
        Console.WriteLine();
        fillCounter = 1;
        return fillCounter;
    }

    private static void matrixD()
    {
        int[,] matrixD = new int[4, 4];
        string direction = "bottom";
        int currentCol = 0;
        int currentRow = 0;

        for (int i = 1; i <= 16; i++)
        {

            if (direction == "bottom" && (currentRow >= matrixD.GetLength(0) || matrixD[currentRow, currentCol] != 0))
            {
                currentRow--;
                currentCol++;
                direction = "right";
            }
            else if (direction == "right" && (currentCol >= matrixD.GetLength(0) || matrixD[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow--;
                direction = "top";
            }
            else if (direction == "top" && (currentRow < 0 || matrixD[currentRow, currentCol] != 0))
            {
                currentRow++;
                currentCol--;
                direction = "left";
            }
            else if (direction == "left" && (currentRow < 0 || matrixD[currentRow, currentCol] != 0))
            {
                direction = "bottom";
                currentRow++;
                currentCol++;
            }

            matrixD[currentRow, currentCol] = i;

            if (direction == "bottom")
            {
                currentRow++;
            }
            else if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "top")
            {
                currentRow--;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
        }
        PrintingMatrix(matrixD);
        Console.WriteLine();
    }

    private static void PrintingMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

