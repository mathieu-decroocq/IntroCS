using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cesi.IntroCS.ConsoleApp;
using System.Collections.Generic;

namespace Cesi.IntroCS.LinqUnitTest
{
    [TestClass]
    public class CombinedExerciseTest
    {
        [TestMethod]
        public void TestForSquares()
        {
            bool result = CombinedExercises.TestForSquares(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 4, 9, 16, 25 });
            Assert.AreEqual(true, result);

            result = CombinedExercises.TestForSquares(new[] { 1, 2, 5 }, new[] { 1, 4, 9 });
            Assert.AreEqual(false, result);

            result = CombinedExercises.TestForSquares(new[] { 12 }, new[] { 144 });
            Assert.AreEqual(true, result);

            result = CombinedExercises.TestForSquares(new[] { 1, 5, 3 }, new[] { 1, 25, 9, 9 });
            Assert.AreEqual(false, result);

            result = CombinedExercises.TestForSquares(new int[0], new int[0]);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetTheLastWord()
        {
            string last = CombinedExercises.GetTheLastWord(new[] { "he", "she", "it", "we", "you", "they" });
            Assert.AreEqual("The last word is we", last);

            last = CombinedExercises.GetTheLastWord(new[] { "hop", "top", "stop", "cop", "lop", "chop" });
            Assert.AreEqual(null, last);

            last = CombinedExercises.GetTheLastWord(new[] { "elastic", "elaborate", "elephant", "iris", "ibis", "incredible" });
            Assert.AreEqual("The last word is incredible", last);

            last = CombinedExercises.GetTheLastWord(new string[0]);
            Assert.AreEqual(null, last);
        }
    }
}
