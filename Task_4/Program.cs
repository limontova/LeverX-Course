using System;
using System.Collections.Generic;

namespace CountIPAddresses
{
    class Program
    {
        static private int[] GetIntArrayFromString(string str)
        {
            int[] array = new int[4];
            int currentNumber = 0;
            string[] substrings = str.Split('.');
            foreach (string substring in substrings)
            {
                array[currentNumber] = int.Parse(substring);
                currentNumber++;
            }
            return array;
        }
        static int Count(string firstAddress, string secondAddress)
        {
            int[] firstIPV4 = new int[4];
            int[] secondIPV4 = new int[4];
            firstIPV4 = GetIntArrayFromString(firstAddress);
            secondIPV4 = GetIntArrayFromString(secondAddress);
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
            Console.WriteLine(Count("10.0.0.0", "10.0.0.50"));
            Console.WriteLine(Count("10.0.0.0", "10.0.1.0"));
            Console.WriteLine(Count("20.0.0.10", "20.0.1.0"));
        }
    }
}
