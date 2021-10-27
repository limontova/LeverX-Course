using System;

namespace Task_4
{
    class Program
    {
        static private int[] TransformIntoArray(string str)
        {
            int[] array = new int[4];
            int i = 0;
            int currentNumber = 0;
            foreach (var symbol in str)
            {
                if (symbol != '.')
                {
                    currentNumber = int.Parse(symbol.ToString()) + currentNumber * 10;
                }
                else
                {
                    array[i] = currentNumber;
                    i++;
                    currentNumber = 0;
                }
            }
            array[3] = currentNumber;
            return array;
        }
        static int Count(string firstAddress, string secondAddress)
        {
            int[] firstIPV4 = new int[4];
            int[] secondIPV4 = new int[4];
            firstIPV4 = TransformIntoArray(firstAddress);
            secondIPV4 = TransformIntoArray(secondAddress);
            int difference = 0;
            int j = 0;
            for (int i = 3; i > 0; i--)
            {
                difference += (secondIPV4[i] - firstIPV4[i]) * (int)(Math.Pow(256, j));
                j++;
            }
            return difference;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Count(Console.ReadLine(), Console.ReadLine()));
            Console.WriteLine(Count("10.0.0.0", "10.0.0.50"));
            Console.WriteLine(Count("10.0.0.0", "10.0.1.0"));
            Console.WriteLine(Count("20.0.0.10", "20.0.1.0"));
        }
    }
}
