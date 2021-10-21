using System;
using System.Collections.Generic;

namespace Task_2
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
        }
    }
}
