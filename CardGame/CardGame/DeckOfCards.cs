using System;
using System.Collections;
using System.Collections.Generic;

namespace CardGame
{
    public class DeckOfCards : ICloneable
    {
        private const int _numberOfCards = 40;
        private List<Card> _cards;
        public int NumberOfCards { get { return _numberOfCards; } }
        public DeckOfCards()
        {
            _cards = new List<Card>(_numberOfCards);
            for(int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    _cards.Add(new Card(i));
                }
            }
        }
        public List<Card> Cards { get { return _cards; } }
        public void FisherYatesShuffleAlgorithm()
        {
            Random random = new Random();
            for(int i = _numberOfCards - 1; i >= 1; i--)
            {
                int randomPosition = random.Next(i + 1);
                Card temp = _cards[i];
                _cards[i] = _cards[randomPosition];
                _cards[randomPosition] = temp;
            }
        }

        public object Clone()
        {
            DeckOfCards clone = new DeckOfCards();
            for(int i = 0; i < _numberOfCards; i++)
            {
                clone.Cards[i] = _cards[i];
            }
            return clone;
        }
    }
}