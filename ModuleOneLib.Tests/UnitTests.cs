using NUnit.Framework;
using Module_1;
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
        public static IEnumerable<TestCaseData> Task1Provider()
        {
            yield return new TestCaseData(10, (BigInteger)23);
            yield return new TestCaseData(-2, (BigInteger)0);
            yield return new TestCaseData(5, (BigInteger)3);
            yield return new TestCaseData(3, (BigInteger)0);
            yield return new TestCaseData(30, (BigInteger)195);
        }

        [Test, TestCaseSource("Task1Provider")]
        public void Task1_GetsValidNumber_ReturnsValidAnswer(int number, BigInteger expected)
        {
            Assert.AreEqual(expected, Homework1.Task1(number));
        }

        public static IEnumerable<TestCaseData> Task2Provider()
        {
            yield return new TestCaseData("aaaaaaaaaa", "12345678910");
            yield return new TestCaseData("Hello, World!", "1112111121311");
        }

        [Test, TestCaseSource("Task2Provider")]
        public void Task2_GetsValidString_ReturnsValidString(string value, string expected)
        {
            Assert.AreEqual(expected, Homework1.Task2(value));
        }

        [Test]
        public void Task3_GetsListOfIntegers_ReturnsValidList()
        {
            //Arrange
            List<int> values = new List<int> { 1, 2, 2, 2, 3, 3, 4, 5, 7 };
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 7};

            //Act
            List<int> actual = Homework1.Task3(values);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Task3_GetsListOfStrings_ReturnsValidList()
        {
            //Arrange
            List<string> values = new List<string> { "abba", "abba", "lala", "uwu", "uwu" };
            List<string> expected = new List<string> { "abba", "lala", "uwu" };

            //Act
            List<string> actual = Homework1.Task3(values);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Task3_GetsListOfChars_ReturnsValidList()
        {
            //Arrange
            List<char> values = new List<char> { 'a', 'g', 'a', 'd', 'd' };
            List<char> expected = new List<char> { 'a', 'g', 'a', 'd' };

            //Act
            List<char> actual = Homework1.Task3(values);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<TestCaseData> Task4Provider()
        {
            yield return new TestCaseData("10.0.0.0", "10.0.0.50", 50);
            yield return new TestCaseData("10.0.0.0", "10.0.1.0", 256);
            yield return new TestCaseData("20.0.0.10", "20.0.1.0", 246);
        }

        [Test, TestCaseSource("Task4Provider")]
        public void Task4_GetsValidString_ReturnsValidNumber(string firstIPV4, string secondIPV4, int expected)
        {
            Assert.AreEqual(expected, Homework1.Task4(firstIPV4, secondIPV4));
        }

        public static IEnumerable<TestCaseData> Task5Provider()
        {
            int[,] array1 = new int[3, 3] { { 1, 2, 3 }, { 8, 9, 4 }, { 7, 6, 5 } };
            int[,] array2 = new int[4, 4] { { 1, 2, 3, 4 }, { 12, 13, 14, 5 }, { 11, 16, 15, 6 }, { 10, 9, 8, 7} };
            int[,] emptyArray = new int[0, 0];
            yield return new TestCaseData(3, array1);
            yield return new TestCaseData(4, array2);
            yield return new TestCaseData(0, emptyArray);
        }


        [Test, TestCaseSource("Task5Provider")]
        public void Task_5_GetsValidNumber_ReturnsValidArray(int number, int[,] expectedArray)
        {
            Assert.AreEqual(expectedArray, Homework1.Task5(number));
        }
    }
}