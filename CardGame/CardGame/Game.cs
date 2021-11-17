using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
    public class Game
    {
        private DeckOfCards _drawPile;
        private DeckOfCards _discardPile;
        public Player _player1;
        public Player _player2;
        private List<Card> _cardsForWinner;
        public Game()
        {
            _drawPile = new DeckOfCards();
            _discardPile = new DeckOfCards();
            _cardsForWinner = new List<Card>();
        }
        public void Start()
        {
            _drawPile.FisherYatesShuffleAlgorithm();
            Card[] cardsForFirstPlayer = new Card[20];
            Card[] cardsForSecondPlayer = new Card[20];
            _drawPile.Cards.CopyTo(0, cardsForFirstPlayer, 0, _drawPile.NumberOfCards / 2);
            _drawPile.Cards.CopyTo(20, cardsForSecondPlayer, 0, _drawPile.NumberOfCards / 2);
            _player1 = new Player(new DeckOfCards(cardsForFirstPlayer.ToList<Card>()));
            _player2 = new Player(new DeckOfCards(cardsForSecondPlayer.ToList<Card>()));
        }
        public bool MakeTurn()
        {
            if (_player1.CheckLoser())
            {
                Output.Show("Player 2 wins the game!");
                return false;
            }
            else if (_player2.CheckLoser())
            {
                Output.Show("Player 1 wins the game!");
                return false;
            }
            int winner = -1;
            Card card1 = _player1.TakeCard();
            Card card2 = _player2.TakeCard();
            if (card1.Number < card2.Number)
            {
                _player2.TakeCardsIntoDiscardPile(card1, card2);
                if (_cardsForWinner.Count != 0)
                {
                    _player2.TakeCardsIntoDiscardPile(_cardsForWinner);
                    _cardsForWinner.Clear();
                }
                winner = 2;
            }
            if (card1.Number > card2.Number)
            {
                _player1.TakeCardsIntoDiscardPile(card1, card2);
                if (_cardsForWinner.Count != 0)
                {
                    _player1.TakeCardsIntoDiscardPile(_cardsForWinner);
                    _cardsForWinner.Clear();
                }
                winner = 1;
            }
            else if (card1.Number == card2.Number)
            {
                _cardsForWinner.Add(card1);
                _cardsForWinner.Add(card2);
            }
            Output.Show($"Player1: {card1.Number} ({_player1.DrawPile.NumberOfCards} cards returned in DrawPile)");
            Output.Show($"Player2: {card2.Number} ({_player2.DrawPile.NumberOfCards} cards returned in DrawPile)");
            if (winner != -1)
            {
                Output.Show($"Player{winner} wins this round \n");
            }
            else
            {
                Output.Show("No winner in this round\n");
            }
            return true;
        }
        public DeckOfCards DrawPile { get { return _drawPile; } }
        public DeckOfCards DiscardPile { set { _discardPile = value; } get { return _discardPile; } }
    }
}