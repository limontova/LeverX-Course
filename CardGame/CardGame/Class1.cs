using System;
using System.Collections;

namespace CardGame
{
    public class Card
    {
        private int _number;
        public int Number { 
            set
            {
                if(value >= 1 && value <= 10)
                {
                    _number = value;
                }
            }
            get
            {
                return _number;
            }
        }
    }

    public class DeckOfCards
    {
        private static ArrayList _cards;
        private static DeckOfCards _deckOfCards;
        private DeckOfCards()
        {
            _cards = new ArrayList(40);
        }
        public static DeckOfCards GetInstance()
        {
            if (_deckOfCards == null)
            {
                _deckOfCards = new DeckOfCards();
            }
            return _deckOfCards;
        }
    }
}