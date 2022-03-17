using System.Collections.Generic;

namespace CardGame
{
    public class Player
    {
        private DeckOfCards _drawPile;
        private DeckOfCards _discardPile;
        public Player(DeckOfCards deckOfCards)
        {
            _drawPile = deckOfCards;
            _discardPile = new DeckOfCards(0);
        }
        public Player()
        {
            _drawPile = new DeckOfCards();
            _discardPile = new DeckOfCards(0);
        }
        public DeckOfCards DrawPile { set { _drawPile = value; } get { return _drawPile; } }
        public DeckOfCards DiscardPile { set { _discardPile = value; } get { return _discardPile; } }
        public bool CheckLoser()
        {
            if (_drawPile.NumberOfCards == 0 && _discardPile.NumberOfCards == 0)
            {
                return true;
            }
            else return false;
        }
        public void DiscardPileShuffledIntoDrawPile()
        {
            _discardPile.FisherYatesShuffleAlgorithm();
            _drawPile = (DeckOfCards)_discardPile.Clone();
            _discardPile.Cards.Clear();
        }
        public bool CheckIfCanTakeTakeCard()
        {
            if (_drawPile.NumberOfCards != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Card TakeCard()
        {
            if (!CheckIfCanTakeTakeCard())
            {
                DiscardPileShuffledIntoDrawPile();
            }
            int indexOfLastElement = _drawPile.NumberOfCards - 1;
            Card lastCard = _drawPile.Cards[indexOfLastElement];
            _drawPile.Cards.RemoveAt(indexOfLastElement);
            return lastCard;
        }

        public void TakeCardsIntoDiscardPile(Card firstCard, Card secondCard)
        {
            _discardPile.Cards.Add(firstCard);
            _discardPile.Cards.Add(secondCard);
        }

        public void TakeCardsIntoDiscardPile(List<Card> cards)
        {
            foreach (var card in cards)
            {
                _discardPile.Cards.Add(card);
            }
        }
    }
}