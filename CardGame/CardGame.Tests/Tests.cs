using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CardGame.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StartGame_ShouldCreateDeckOf40Cards()
        {
            //Arrange
            Game game = new Game();
            int expectedNumberOfCards = 40;
            //Act
            game.Start();
            //Assert
            Assert.AreEqual(expectedNumberOfCards, game.DeckOfCards.NumberOfCards);
        }

        [Test]
        public void FisherYatesShuffleAlgorith_ShouldShuffleDeckOfCards()
        {
            //Arrange
            DeckOfCards deckOfCards = new DeckOfCards();
            DeckOfCards initialVersionOfDecks = new DeckOfCards();
            initialVersionOfDecks = (DeckOfCards)deckOfCards.Clone();
            //Act
            deckOfCards.FisherYatesShuffleAlgorithm();
            bool areEqual = initialVersionOfDecks.Cards.SequenceEqual(deckOfCards.Cards);
            //Assert
            Assert.IsFalse(areEqual);
        }
    }
}