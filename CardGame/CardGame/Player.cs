using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Player
    {
        private DeckOfCards _deckOfCards;
        public Player(DeckOfCards deckOfCards)
        {
            _deckOfCards = new DeckOfCards();
            _deckOfCards = deckOfCards;
        }
        public Player()
        {
            _deckOfCards = new DeckOfCards();
        }
        public DeckOfCards DeckOfCards { set { _deckOfCards = value; } get { return _deckOfCards; } }
    }
}
