using NUnit.Framework;
using System;

namespace Summator.Tests
{
    [TestFixture]

    public class SummatorTests
    {
        private Summator summator;

        [SetUp]
        public void SetUp()
        {
            summator = new Summator();
            System.Console.WriteLine("Test started: " + DateTime.Now);
        }

        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            long actual = summator.Sum(new int[] { 5, 7 });
            int expected = 12;
            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_OnePossitiveNumber()
        {
            long actual = summator.Sum(new int[] { 5 });
            Assert.That(actual == 5);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long actual = summator.Sum(new int[] { -7, -9 });
            Assert.That(actual == -16);
        }

        [Test]
        public void Test_Sum_Zero()
        {
            long actual = summator.Sum(new int[] { });
            Assert.That(actual == 0);
        }

        [Test]
        public void Test_Sum_BigVallues()
        {
            long actual = summator.Sum(new int[] { 2000000000, 2000000000, 2000000000, 2000000000 });
            Assert.AreEqual(8000000000, actual);
            
        }

        [Test]
        public void Test_Average_TwoPossitiveNumbers()
        {
            int actual = Summator.Average(new int[] { 5, 7 });
            int expected = 6;
            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Assertions()
        {
            var value = new int[] { 5, 7 };
            int expected = 12;
            long actual = summator.Sum(value);

            Assert.That(expected == actual);
            Assert.That(expected, Is.EqualTo(actual));
            Assert.AreEqual(expected, actual);

            double percentage = 99.95;
            Assert.That(percentage, Is.InRange(80, 100));
            Assert.That("QA is awesome", Does.Contain("awesome"));

        }

        [TearDown]
        public void TearDown()
        {
            summator = null;
            System.Console.WriteLine("Test ended: " + DateTime.Now);
        }
    }
}