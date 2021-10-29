using NUnit.Framework;
using System.Collections.Generic;
using Task6_Part2;

namespace Task6_Part2.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CountPriceOfAllBooks_BuyAllBooks_ShouldReturnCost25Discount()
        {
            //Arrange
            int copiesOfFirstBook = 2;
            int copiesOfSecondBook = 2;
            int copiesOfThirdBook = 2;
            int copiesOfFourthBook = 1;
            int copiesOfFifthBook = 1;

            //Act
            double actual = BookShop.CountPriceOfAllBooks(copiesOfFirstBook, copiesOfSecondBook, copiesOfThirdBook, copiesOfFourthBook, copiesOfFifthBook);

            //Assert
            Assert.AreEqual(51.6, actual);
        }

        [TestCase(0, 2, 1, 1, 5)]
        [TestCase(2, 1, 0, 5, 1)]
        public void CountPriceOfAllBooks_BuyAllBooks_ShouldReturnCost25Discount(int copiesOfFirstBook, int copiesOfSecondBook, int copiesOfThirdBook, int copiesOfFourthBook, int copiesOfFifthBook)
        {
            //Act
            double actual = BookShop.CountPriceOfAllBooks(copiesOfFirstBook, copiesOfSecondBook, copiesOfThirdBook, copiesOfFourthBook, copiesOfFifthBook);

            //Assert
            Assert.AreEqual(64.8, actual);
        }

        public static IEnumerable<TestCaseData> NumberOfBooksProvider()
        {
            yield return new TestCaseData(1, 0, 0, 0, 0, 8);
            yield return new TestCaseData(3, 2, 0, 0, 0, 38.4);
            yield return new TestCaseData(1, 2, 6, 0, 0, 68.8);
            yield return new TestCaseData(2, 2, 3, 1, 0, 55.2);
            yield return new TestCaseData(3, 2, 5, 1, 2, 86.8);
        }

        [Test, TestCaseSource("NumberOfBooksProvider")]
        public void CountPriceOfAllBooks_BuyAllBooks_ShouldReturnCost25Discount(int copiesOfFirstBook, int copiesOfSecondBook, int copiesOfThirdBook, int copiesOfFourthBook, int copiesOfFifthBook, double expectedSum)
        {
            //Act
            double actual = BookShop.CountPriceOfAllBooks(copiesOfFirstBook, copiesOfSecondBook, copiesOfThirdBook, copiesOfFourthBook, copiesOfFifthBook);

            //Assert
            Assert.AreEqual(expectedSum, actual);
        }
    }
}