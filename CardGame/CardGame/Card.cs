namespace CardGame
{
    public class Card
    {
        private int _number;
        public int Number
        {
            set
            {
                if (value >= 1 && value <= 10)
                {
                    _number = value;
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
