using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Game
    {
        private DeckOfCards _drawPile;
        private DeckOfCards _discardPile;
        public Player Player1;
        public Player Player2;

        public void OnePlayerTurn(Player player)
        {
            if (_drawPile.Cards.Count == 0)
            {
                _discardPile.FisherYatesShuffleAlgorithm();
                _drawPile = (DeckOfCards)_discardPile.Clone();
                _discardPile.Cards.Clear();
            }
            else
            {
                int indexOfLastElement = _drawPile.Cards.Count - 1;
                player.TakeCard(_drawPile.Cards[indexOfLastElement]);
                _drawPile.Cards.RemoveAt(indexOfLastElement);
            }
        }

        private bool CheckIfPlayerLoses(Player player)
        {
            if(_discardPile.Cards.Count == 0 && player.DeckOfCards.Cards.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Game()
        {
            _drawPile = new DeckOfCards();
            _discardPile = new DeckOfCards();
            Player1 = new Player();
            Player2 = new Player();
        }

        public void Start()
        {
            _drawPile.FisherYatesShuffleAlgorithm();
            _drawPile.Cards.CopyTo(0, Player1.DeckOfCards.Cards.ToArray(), 0, _drawPile.Cards.Count / 2);
            _drawPile.Cards.CopyTo(20, Player2.DeckOfCards.Cards.ToArray(), 0, _drawPile.Cards.Count / 2);        
        }

        public void MakeTurn()
        {
            OnePlayerTurn(Player1);
            OnePlayerTurn(Player2);
            CheckIfPlayerLoses(Player1);
            CheckIfPlayerLoses(Player2);
        }
        public DeckOfCards DrawPile { get { return _drawPile; } }//should I use Set? (If it only for tests)
        public DeckOfCards DiscardPile { set { _discardPile = value; } get { return _discardPile; } }
    }
}