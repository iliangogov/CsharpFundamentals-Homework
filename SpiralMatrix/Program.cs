using System;
namespace SpiralMatrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            int direction = 1;
            int row = 0;
            int col = 0;
            int count = n - 1;
            int number = 1;

            for (int i = 0; i < n; i++)
            {
                array[row, col++] = number++;
            }
            col--;

            for (int j = 0; j < n - 1; j++)
            {
                if (direction == 1)
                {
                    for (int i = 0; i < count; i++)
                    {
                        array[++row, col] = number++;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        array[row, --col] = number++;
                    }
                    count--;
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        array[--row, col] = number++;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        array[row, ++col] = number++;
                    }
                    count--;
                }
                direction *= -1;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (n > 9)
                    {
                        Console.Write("{0} ", array[i, j]);
                    }
                    else if (n > 3)
                    {
                        Console.Write("{0} ", array[i, j]);
                    }
                    else
                    {
                        Console.Write("{0} ", array[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
