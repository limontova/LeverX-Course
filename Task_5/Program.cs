using System;

namespace Task_5
{
    class Program
    {
        static void printArray(int[,] array)
        {
            int arrayLength = (int)Math.Sqrt(array.Length);
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    Console.Write($"{array[i,j]} ");
                }
                Console.Write('\n');
            }
        }
        static int[,] createSpiral(int N)
        {
            int[,] array = new int[N,N];
            int j = -1;
            int i = 0;
            int currentNumber = 1;
            int limitI = N - 1;
            int limitJ = N - 1;
            while(currentNumber <= N * N)
            {
                while(j < limitJ)
                {
                    j++;
                    array[i, j] = currentNumber;                    
                    currentNumber++;
                }
                limitJ--;

                while (i < limitI)
                {
                    i++;
                    array[i, j] = currentNumber;
                    currentNumber++;
                }
                limitI--;

                while (j > N - limitJ - 2)
                {
                    j--;
                    array[i, j] = currentNumber;                   
                    currentNumber++;
                }

                while (i > N - limitI - 1)
                {
                    i--;
                    array[i, j] = currentNumber;                   
                    currentNumber++;
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            printArray(createSpiral(5));
        }
    }
}
