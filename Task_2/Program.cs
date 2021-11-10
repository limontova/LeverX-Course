using System;
using System.Collections.Generic;

namespace NumericalsOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> arrayOfChars = new Dictionary<char, int>();
            string result = string.Empty;

            foreach (var symbol in input)
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
            Console.WriteLine(result);
        }
    }
}