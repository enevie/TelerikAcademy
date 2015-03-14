namespace _02.EnterNumbers
{
    using System;

    class Numbers
    {
        static void ReadNumber(int start, int end)
        {
            int[] number = new int[10];
            try
            {
                Console.WriteLine("Write number");
                for (int i = 1; i < 10; i++)
                {

                    number[i] = int.Parse(Console.ReadLine());
                    if (i == 1)
                    {
                        if (number[i] < 0 || number[i] < start || number[i] > end)
                        {
                            throw new ArgumentException("Invalid number!");
                        }
                        Console.WriteLine("Write number larger than privious");
                        continue;
                    }
                    else
                    {

                        if (number[i - 1] > number[i] || number[i-1] == number[i])
                        {
                            throw new ArgumentException("Invalid number!");
                        }

                        if (number[i] < 0 || number[i] < start || number[i] > end)
                        {
                            throw new ArgumentException("Invalid number!");
                        }
                        Console.WriteLine("Write number larger than privious");
                    }

                }
                Console.WriteLine("Numbers Accepted!");
            }
            catch
            {
                Console.WriteLine("Invalid number!");
            }
        }

        static void Main()
        {

          ReadNumber(1, 100);
        }
    }
}
