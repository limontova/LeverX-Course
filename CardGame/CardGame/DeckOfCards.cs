using System;
using System.Collections.Generic;

namespace CardGame
{
    public class DeckOfCards : ICloneable
    {
        private const int _initialNumberOfCards = 40;
        private List<Card> _cards;
        public DeckOfCards()
        {
            _cards = new List<Card>(_initialNumberOfCards);
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    _cards.Add(new Card(i));
                }
            }
        }
        public DeckOfCards(int numberOfCards)
        {
            _cards = new List<Card>(numberOfCards);
            for (int i = 0; i < numberOfCards; i++)
            {
                _cards.Add(new Card(0));
            }
        }
        public List<Card> Cards { get { return _cards; } set { _cards = value; } }
        public void FisherYatesShuffleAlgorithm()
        {
            Random random = new Random();
            for (int i = _cards.Count - 1; i >= 1; i--)
            {
                int randomPosition = random.Next(i + 1);
                Card temp = _cards[i];
                _cards[i] = _cards[randomPosition];
                _cards[randomPosition] = temp;
            }
        }
        public object Clone()
        {
            DeckOfCards clone = new DeckOfCards(_cards.Count);
            for (int i = 0; i < _cards.Count; i++)
            {
                clone.Cards[i] = _cards[i];
            }
            return clone;
        }
    }
}