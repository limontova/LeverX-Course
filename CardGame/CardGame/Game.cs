using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Game
    {
        private DeckOfCards _deckOfCards;
        
        public void Start()
        {
            _deckOfCards = new DeckOfCards();
            _deckOfCards.FisherYatesShuffleAlgorithm();
            Player Player1 = new Player();
            _deckOfCards.Cards.CopyTo(0, Player1.DeckOfCards.Cards.ToArray(), 0, _deckOfCards.NumberOfCards / 2);
            Player Player2 = new Player();
            _deckOfCards.Cards.CopyTo(20, Player2.DeckOfCards.Cards.ToArray(), 0, _deckOfCards.NumberOfCards / 2);
        }
        public DeckOfCards DeckOfCards { get { return _deckOfCards; } }
    }
}
