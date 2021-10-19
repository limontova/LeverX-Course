using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static int Sum(params int[] integers)
        {
            int result = 0;
            for(int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            return result;
        }

        static int[] GetNumbersMultuplesOfThreeAndFive(int limit)
        {
            List<int> numbers = new List<int>();
            int currentNumber = 3;
            while(currentNumber < limit)
            {
                if (currentNumber % 3 == 0 || currentNumber % 5 == 0)
                {
                    numbers.Add(currentNumber);
                }
                currentNumber++;
            }
            return numbers.ToArray();
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input <= 0)
                Console.WriteLine("0");
            else
                Console.WriteLine(Sum(GetNumbersMultuplesOfThreeAndFive(input)));
        }
    }
}
