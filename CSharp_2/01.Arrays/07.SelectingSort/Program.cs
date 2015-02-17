using System;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.


class SelectingSort
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter how many numbers you want in the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter the numbers: ");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int minNumber, index, j, temp;

        for (index = 0; index < arr.Length - 1; index++)
        {
            minNumber = index;
            for (j = index + 1; j < n; j++)
            {
                if (arr[j] < arr[minNumber])
                {
                    minNumber = j;
                }
            }
            if (minNumber != index)
            {
                temp = arr[index];
                arr[index] = arr[minNumber];
                arr[minNumber] = temp;
            }
        }
        Console.WriteLine(string.Join(", ", arr));
    }
}

