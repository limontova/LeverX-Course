using System;
using System.Numerics;

namespace Task_1
{
    class Program
    {
        static BigInteger GetSumOfArithmeticProgression(BigInteger arithmeticDifference, BigInteger limit)
        {
            BigInteger numberOfElements = (limit - 1) / arithmeticDifference;
            return arithmeticDifference * numberOfElements * (numberOfElements + 1) / 2;
        }

        static BigInteger Calculate(BigInteger number)
        {
            if (number <= 3)
                return 0;
            else
            {
                return GetSumOfArithmeticProgression(3, number) + GetSumOfArithmeticProgression(5, number) - GetSumOfArithmeticProgression(15, number);
            }
        }

        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(input));
        }
    }
}
