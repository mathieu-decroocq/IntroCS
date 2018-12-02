using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cesi.IntroCS.ConsoleApp;
using System.Collections.Generic;

namespace Cesi.IntroCS.LinqUnitTest
{
    [TestClass]
    public class CombinedExercise1Test
    {
        [TestMethod]
        public void TestForSquares()
        {
            bool result = CombinedExercise1.TestForSquares(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 4, 9, 16, 25 });
            Assert.AreEqual(true, result);

            result = CombinedExercise1.TestForSquares(new[] { 1, 2, 5 }, new[] { 1, 4, 9 });
            Assert.AreEqual(false, result);

            result = CombinedExercise1.TestForSquares(new[] { 12 }, new[] { 144 });
            Assert.AreEqual(true, result);

            result = CombinedExercise1.TestForSquares(new[] { 1, 5, 3 }, new[] { 1, 25, 9, 9 });
            Assert.AreEqual(false, result);

            result = CombinedExercise1.TestForSquares(new int[0], new int[0]);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetTheLastWord()
        {
            string last = CombinedExercise2.GetTheLastWord(new[] { "he", "she", "it", "we", "you", "they" });
            Assert.AreEqual("The last word is we", last);

            last = CombinedExercise2.GetTheLastWord(new[] { "hop", "top", "stop", "cop", "lop", "chop" });
            Assert.AreEqual(null, last);

            last = CombinedExercise2.GetTheLastWord(new[] { "elastic", "elaborate", "elephant", "iris", "ibis", "incredible" });
            Assert.AreEqual("The last word is incredible", last);

            last = CombinedExercise2.GetTheLastWord(new string[0]);
            Assert.AreEqual(null, last);
        }
    }
}
