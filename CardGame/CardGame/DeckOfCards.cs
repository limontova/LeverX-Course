using System;
using System.Collections.Generic;

namespace CardGame
{
    public class DeckOfCards
    {
        private List<Card> _cards;
        public DeckOfCards()
        {
            _cards = new List<Card>(GameConfig.initialNumberOfCards);
            for (int j = 0; j < GameConfig.timesCardInDeck; j++)
            {
                for (int i = 0; i < GameConfig.initialNumberOfCards / GameConfig.timesCardInDeck; i++)
                {
                    _cards.Add(new Card(i));
                }
            }
        }
        public DeckOfCards(List<Card> cards)
        {
            _cards = cards;
        }
        public int NumberOfCards { get { return _cards.Count; } }
        public DeckOfCards(int numberOfCards)
        {
            _cards = new List<Card>(numberOfCards);
            for (int i = 0; i < numberOfCards; i++)
            {
                _cards.Add(new Card(0));
            }
        }
        public List<Card> Cards { get { return _cards; } }
        public void AddCard(Card card)
        {
            _cards.Add(card);
        }
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
        public DeckOfCards Clone()
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