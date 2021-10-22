using System;
using System.Collections.Generic;

namespace Task_3
{
    class Program
    {
        static List<T> UniqueInOrder<T>(IEnumerable<T> sequence) where T : IEquatable<T>
        {
            var result = new List<T>();
            T previousSymbol = sequence.GetEnumerator().Current;
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
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int>() { 1, 2, 3, 3, 4, 4 , 4, 4 , 5};

            UniqueInOrder(numbers);
        }
    }
}
