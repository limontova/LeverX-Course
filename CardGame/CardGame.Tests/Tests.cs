using NUnit.Framework;
using System.Linq;
using System;

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
            Assert.AreEqual(expectedNumberOfCards, game.DrawPile.Cards.Count);
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

        [Test]
        public void PlayerTriesToTakeCardFromEmptyDrawPile_ShouldShuffleDiscardPileIntoDrawPile()
        {
            //Arrange
            Player player = new Player();
            player.DrawPile.FisherYatesShuffleAlgorithm();
            player.DiscardPile = (DeckOfCards)player.DrawPile.Clone();
            player.DrawPile.Cards.Clear();
            //Act
            player.DiscardPileShuffledIntoDrawPile();
            //Assert
            Assert.AreEqual(40, player.DrawPile.Cards.Count);
        }

        [Test]
        public void ComparingTwoCards_HigherCardShouldWin()
        {
            //Arrange
            Game game = new Game();
            game.Start();
            game._player1.DrawPile.Cards[game._player1.DrawPile.Cards.Count - 1].Number = 3;
            game._player2.DrawPile.Cards[game._player2.DrawPile.Cards.Count - 1].Number = 1;
            //Act
            game.MakeTurn();
            //Assert
            Assert.AreEqual(game._player1.DiscardPile.Cards.Count, 2);
        }

        [Test]
        public void ComparingTwoCardsWithSameValue_WinnerShouldGet4NetTurn()
        {
            //Arrange
            Game game = new Game();
            game.Start();
            game._player1.DrawPile.Cards[game._player1.DrawPile.Cards.Count - 1].Number = 3;
            game._player2.DrawPile.Cards[game._player1.DrawPile.Cards.Count - 1].Number = 3;
            game._player1.DrawPile.Cards[game._player2.DrawPile.Cards.Count - 2].Number = 5;
            game._player2.DrawPile.Cards[game._player1.DrawPile.Cards.Count - 2].Number = 3;
            //Act
            game.MakeTurn();
            game.MakeTurn();
            //Assert
            Assert.AreEqual(game._player1.DiscardPile.Cards.Count, 4);
        }
    }
}