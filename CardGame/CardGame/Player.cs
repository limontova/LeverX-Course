using System.Collections.Generic;

namespace CardGame
{
    public class Player
    {
        private DeckOfCards _drawPile;
        private DeckOfCards _discardPile;
        private bool _winner;
        public Player(DeckOfCards deckOfCards)
        {
            _drawPile = new DeckOfCards();
            _drawPile = deckOfCards;
            _discardPile = new DeckOfCards();
            _discardPile.Cards.Clear();
        }
        public Player()
        {
            _drawPile = new DeckOfCards();
            _discardPile = new DeckOfCards();
            _discardPile.Cards.Clear();
        }
        public DeckOfCards DrawPile { set { _drawPile = value; } get { return _drawPile; } }
        public DeckOfCards DiscardPile { set { _discardPile = value; } get { return _discardPile; } }
        public bool Winner { set { _winner = value; } get { return _winner; } }
        public bool CheckLoser()
        {
            if (_drawPile.Cards.Count == 0 && _discardPile.Cards.Count == 0)
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
        public bool TryToTakeCard()
        {
            if (_drawPile.Cards.Count != 0)
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
            if (!TryToTakeCard())
            {
                DiscardPileShuffledIntoDrawPile();
            }
            int indexOfLastElement = _drawPile.Cards.Count - 1;
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