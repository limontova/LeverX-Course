using System;
using System.Collections.Generic;
using System.Numerics;

namespace ModuleOneLib
{
    public class Homework1
    {
        static public BigInteger MultiplesOfThreeOrFive(BigInteger number)
        {
            static BigInteger GetSumOfArithmeticProgression(BigInteger arithmeticDifference, BigInteger limit)
            {
                BigInteger numberOfElements = (limit - 1) / arithmeticDifference;
                return arithmeticDifference * numberOfElements * (numberOfElements + 1) / 2;
            }

            if (number <= 3)
                return 0;
            else
            {
                return GetSumOfArithmeticProgression(3, number) + GetSumOfArithmeticProgression(5, number) - GetSumOfArithmeticProgression(15, number);
            }
        }
        static public string NumericalsOfString(string str)
        {
            Dictionary<char, int> arrayOfChars = new Dictionary<char, int>();
            string result = string.Empty;

            foreach (var symbol in str)
            {
                if (!arrayOfChars.ContainsKey(symbol))
                {
                    arrayOfChars.Add(symbol, 1);
                }
                else
                {
                    arrayOfChars[symbol]++;
                }
                result += arrayOfChars[symbol];
            }
            return result;
        }

        static public List<T> UniqueInOrder<T>(IEnumerable<T> sequence) where T : IEquatable<T>
        {
            var result = new List<T>();
            sequence.GetEnumerator().Reset();
            IEnumerator<T> iterator = sequence.GetEnumerator();
            iterator.MoveNext();
            T previousSymbol = iterator.Current;
            bool was = false;
            foreach (var element in sequence)
            {
                if (was)
                {
                    if (!previousSymbol.Equals(element))
                    {
                        result.Add(element);
                        previousSymbol = element;
                    }
                }
                else
                {
                    was = true;
                    result.Add(element);
                }
            }
            return result;
        }

        static public int CountIPAddress(string firstAddress, string secondAddress)
        {
            static int[] GetIntArrayFromString(string str)
            {
                List<int> array = new List<int>(4);
                foreach(var digit in str.Split('.'))
                {
                    array.Add(int.Parse(digit));
                }
                return array.ToArray();
            }
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

        static public int[,] ClockwiseSpiral(int N)
        {
            static void printArray(int[,] array, int biggestNumber)
            {
                int arrayLength = (int)Math.Sqrt(array.Length);
                for (int i = 0; i < arrayLength; i++)
                {
                    for (int j = 0; j < arrayLength; j++)
                    {
                        Console.Write("{0,12} ", array[i, j]);
                    }
                    Console.Write('\n');
                }
            }
            if (N < 1)
            {
                return new int[0, 0];
            }
            int[,] array = new int[N, N];
            int j = -1;
            int i = 0;
            int currentNumber = 1;
            int limitI = N - 1;
            int limitJ = N - 1;
            while (currentNumber <= N * N)
            {
                while (j < limitJ)
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
            printArray(array, N * N);
            return array;
        }
    }
}
