using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestFixture]
    public class LoopExercisesTest
    {
        LoopExercises target = new LoopExercises();

        //RepeatNumber
        /// Given a number 1-9, return a string with repeating with that number.
        [TestCase(1, "1")]
        [TestCase(4, "4444")]
        public void RepeatNumberTest(int n, string expected)
        {
            string actual = target.RepeatNumber(n);
            Assert.AreEqual(expected, actual);
        }
        // RomanNumeral
        /// Given an int, return the roman numeral
        [TestCase(1, "I")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        public void RomanNumeralTest(int n, string expected)
        {
            string actual = target.RomanNumeral(n);
            Assert.AreEqual(expected, actual);
        }
        // SumNumbers
        /// Given a non-negative number, return the sum of it's digits
        [TestCase(1234, 10)]
        [TestCase(9010, 10)]
        [TestCase(222222, 12)]
        public void SumNumbersTest(int n, int expected)
        {
            int actual = target.SumNumbers(n);
            Assert.AreEqual(expected, actual);
        }
        // MirrorWord
        /// Given an string, return true or false if the word when split is mirrored
        [TestCase("abccba", true)]
        [TestCase("cbaabc", true)]
        [TestCase("asdasd", false)]
        public void MirrorWordTest(string input, bool expected)
        {
            bool actual = target.MirrorWord(input);
            Assert.AreEqual(expected, actual);
        }
        // SumBetween
        // Given two numbers, n and m, return the sum of all numbers in between inclusive
        [TestCase(1,3,6)]
        [TestCase(5,9,35)]
        [TestCase(-10,0,-55)]
        public void SumBetweenTest(int n, int m, int expected)
        {
            int actual = target.SumBetween(n, m);
            Assert.AreEqual(expected, actual);
        }
    }
}
