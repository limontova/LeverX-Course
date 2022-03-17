using NUnit.Framework;
using BookShop;
using System.Collections.Generic;

namespace BookShop.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        public static IEnumerable<TestCaseData> NumberOfBooksProvider()
        {
            yield return new TestCaseData(new Books(new int[5] { 1, 0, 0, 0, 0 }), 8);
            yield return new TestCaseData(new Books(new int[5] { 3, 2, 0, 0, 0 }), 38.4);
            yield return new TestCaseData(new Books(new int[5] { 1, 2, 6, 0, 0 }), 68.8);
            yield return new TestCaseData(new Books(new int[5] { 2, 2, 3, 1, 0 }), 55.2);
            yield return new TestCaseData(new Books(new int[5] { 3, 2, 5, 1, 2 }), 86.8);
            yield return new TestCaseData(new Books(new int[5] { 0, 1, 2, 1, 5 }), 64.8);
            yield return new TestCaseData(new Books(new int[5] { 2, 2, 2, 1, 1 }), 51.6);
        }

        [Test, TestCaseSource("NumberOfBooksProvider")]
        public void CountPriceOfAllBooks_BuyAllBooks_ShouldReturnCost25Discount(Books books, double expectedSum)
        {
            //Act
            double actual = OperationsWithBooks.CountPriceOfAllBooks(books);

            //Assert
            Assert.AreEqual(expectedSum, actual);
        }
    }
}