using System;

namespace CardGame
{
    public class Card
    {
        private int _number;
        public int Number
        {
            set
            {
                try
                {
                    if (value >= 1 && value <= 10)
                    {
                        _number = value;
                    }
                    else
                    {
                        throw new Exception("Value can not be less than 1 and more than 10");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            get
            {
                return _number;
            }
        }
        public Card(int number)
        {
            Number = number;
        }
        public Card()
        {
        }
    }
}
