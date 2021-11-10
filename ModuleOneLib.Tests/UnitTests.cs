using NUnit.Framework;
using ModuleOneLib;
using System.Numerics;
using System.Collections.Generic;

namespace ModuleOneLib.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        public static IEnumerable<TestCaseData> NumbersProvider()
        {
            yield return new TestCaseData(10, (BigInteger)23);
            yield return new TestCaseData(-2, (BigInteger)0);
            yield return new TestCaseData(5, (BigInteger)3);
            yield return new TestCaseData(3, (BigInteger)0);
            yield return new TestCaseData(30, (BigInteger)195);
        }
        
        [Test, TestCaseSource("NumbersProvider")]
        public void MultiplesOfThreeOrFive_GetsValidNumber_ReturnsValidAnswer(int number, BigInteger expected)
        {
            Assert.AreEqual(expected, Homework1.MultiplesOfThreeOrFive(number));
        }

        public static IEnumerable<TestCaseData> StringProvider()
        {
            yield return new TestCaseData("aaaaaaaaaa", "12345678910");
            yield return new TestCaseData("Hello, World!", "1112111121311");
        }

        [Test, TestCaseSource("StringProvider")]
        public void NumericalsOfString_GetsValidString_ReturnsStringWithAmountOfOccurrenceOfSymbols(string value, string expected)
        {
            Assert.AreEqual(expected, Homework1.NumericalsOfString(value));
        }

        [Test]
        public void UniqueInOrder_GetsListOfIntegers_ReturnsValidList()
        {
            //Arrange
            List<int> values = new List<int> { 1, 2, 2, 2, 3, 3, 4, 5, 7 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 7};

            //Act
            List<int> actual = Homework1.UniqueInOrder(values);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void UniqueInOrder_GetsListOfStrings_ReturnsValidList()
        {
            //Arrange
            List<string> values = new List<string> { "abba", "abba", "lala", "uwu", "uwu" };
            List<string> expected = new List<string> { "abba", "lala", "uwu" };

            //Act
            List<string> actual = Homework1.UniqueInOrder(values);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void UniqueInOrder_GetsListOfChars_ReturnsValidList()
        {
            //Arrange
            List<char> values = new List<char> { 'a', 'g', 'a', 'd', 'd' };
            List<char> expected = new List<char> { 'a', 'g', 'a', 'd' };

            //Act
            List<char> actual = Homework1.UniqueInOrder(values);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<TestCaseData> IPProvider()
        {
            yield return new TestCaseData("10.0.0.0", "10.0.0.50", 50);
            yield return new TestCaseData("10.0.0.0", "10.0.1.0", 256);
            yield return new TestCaseData("20.0.0.10", "20.0.1.0", 246);
        }

        [Test, TestCaseSource("IPProvider")]
        public void CountIPAddress_GetsValidString_ReturnsValidNumber(string firstIPV4, string secondIPV4, int expected)
        {
            Assert.AreEqual(expected, Homework1.CountIPAddress(firstIPV4, secondIPV4));
        }

        public static IEnumerable<TestCaseData> ArrayProvider()
        {
            int[,] array1 = new int[3, 3] { { 1, 2, 3 }, { 8, 9, 4 }, { 7, 6, 5 } };
            int[,] array2 = new int[4, 4] { { 1, 2, 3, 4 }, { 12, 13, 14, 5 }, { 11, 16, 15, 6 }, { 10, 9, 8, 7} };
            int[,] emptyArray = new int[0, 0];
            yield return new TestCaseData(3, array1);
            yield return new TestCaseData(4, array2);
            yield return new TestCaseData(0, emptyArray);
        }


        [Test, TestCaseSource("ArrayProvider")]
        public void ClockwiseSpiral_GetsValidNumber_ReturnsValidArray(int number, int[,] expectedArray)
        {
            Assert.AreEqual(expectedArray, Homework1.ClockwiseSpiral(number));
        }
    }
}