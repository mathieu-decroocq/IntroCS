using Cesi.IntroCS.LinqClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.IntroCS.LinqUnitTest
{
    [TestClass]
    public class SingleCalculatedValueExercisesTest
    {
        [TestMethod]
        public void NumberThatStartWith()
        {
            var words = "This is the first test".Split(' ');
            var answer = SingleCalculatedValueExercises.NumberThatStartWith(words, "is");
            Assert.AreEqual("1", answer.ToString());

            words = "I'm sorry Dave I can't do that".Split(' ');
            answer = SingleCalculatedValueExercises.NumberThatStartWith(words, "I");
            Assert.AreEqual("2", answer.ToString());

            words = "She sells sea shells down by the sea shore".Split(' ');
            answer = SingleCalculatedValueExercises.NumberThatStartWith(words, "se");
            Assert.AreEqual("3", answer.ToString());
        }

        [TestMethod]
        public void LengthOfShortestWord()
        {
            var words = "This is the first test".Split(' ');
            var answer = SingleCalculatedValueExercises.LengthOfShortestWord(words);
            Assert.AreEqual("2", answer.ToString());

            words = "I'm sorry Dave I can't do that".Split(' ');
            answer = SingleCalculatedValueExercises.LengthOfShortestWord(words);
            Assert.AreEqual("1", answer.ToString());

            words = "She sells sea shells down by the sea shore".Split(' ');
            answer = SingleCalculatedValueExercises.LengthOfShortestWord(words);
            Assert.AreEqual("2", answer.ToString());
        }
    }
}
