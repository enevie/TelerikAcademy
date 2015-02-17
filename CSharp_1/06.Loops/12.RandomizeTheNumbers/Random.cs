using System;




class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Random random = new Random();
        int[] randomNumbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            randomNumbers[i] = random.Next(1, n);
            Console.Write(randomNumbers[i] + " ");
        }

    }
}

