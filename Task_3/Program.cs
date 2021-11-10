using System;
using System.Collections.Generic;

namespace UniqueInOrder
{
    class Program
    {
        static List<T> UniqueInOrder<T>(IEnumerable<T> sequence) where T : IEquatable<T>
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
        static void PrintList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int>() { 0, 1, 2, 3, 3, 4, 4, 4, 4, 5 };
            IEnumerable<string> strings = new List<string>() { "abb", "abb", "Abb", "ABb", "ABff" };
            IEnumerable<char> chars = new List<char>() { 'a', 'a', 'a', 'b', 'f' };

            PrintList(UniqueInOrder(numbers));
            PrintList(UniqueInOrder(strings));
            PrintList(UniqueInOrder(chars));
        }
    }
}
