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

        public static IEnumerable<TestCaseData> NumberOfBooksProvider()
        {
            yield return new TestCaseData(1, 0, 0, 0, 0, 8);
            yield return new TestCaseData(3, 2, 0, 0, 0, 38.4);
            yield return new TestCaseData(1, 2, 6, 0, 0, 68.8);
            yield return new TestCaseData(2, 2, 3, 1, 0, 55.2);
            yield return new TestCaseData(3, 2, 5, 1, 2, 86.8);
            yield return new TestCaseData(0, 1, 2, 1, 5, 64.8);
            yield return new TestCaseData(2, 2, 2, 1, 1, 51.6);
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