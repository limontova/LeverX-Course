using System;
using System.Collections.Generic;
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
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            if (input <= 3)
                Console.WriteLine("0");
            else
            {
                //--input;
                Console.WriteLine(GetSumOfArithmeticProgression(3, input) + GetSumOfArithmeticProgression(5, input) - GetSumOfArithmeticProgression(15, input));
            }
        }
    }
}
