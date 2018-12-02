using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cesi.IntroCS.LinqClassLibrary;
using System.Linq;

namespace Cesi.IntroCS.LinqUnitTest
{
    [TestClass]
    public class SingleValueExerciseTest
    {
        [TestMethod]
        public void GetFirstSingleLetterWord()
        {
            var answer = SingleValueExercise.GetFirstSingleLetterWord(new List<string> { "This", "is", "a", "test" });
            Assert.AreEqual("a", answer);

            answer = SingleValueExercise.GetFirstSingleLetterWord(new List<string> { "I", "am", "not", "a", "crook" });
            Assert.AreEqual("I", answer);

            answer = SingleValueExercise.GetFirstSingleLetterWord("deadbeef".ToCharArray().Select(l => l.ToString()));
            Assert.AreEqual("d", answer);
        }

        [TestMethod]
        public void GetLastWordWithHerInIt()
        {
            var answer = SingleValueExercise.GetLastWordWithHerInIt("Watching the weather together with her".Split(' '));
            Assert.AreEqual("her", answer);

            answer = SingleValueExercise.GetLastWordWithHerInIt("Watching the watcher alone".Split(' '));
            Assert.AreEqual("watcher", answer);

            answer = SingleValueExercise.GetLastWordWithHerInIt("where where where where".Split(' '));
            Assert.AreEqual("where", answer);
        }

        [TestMethod]
        public void GetFifthWordIfItExists()
        {
            var answer = SingleValueExercise.GetFifthWordIfItExists("Watching the weather together with her".Split(' '));
            Assert.AreEqual("with", answer);

            answer = SingleValueExercise.GetFifthWordIfItExists("Watching the watcher alone".Split(' '));
            Assert.AreEqual(null, answer);

            answer = SingleValueExercise.GetFifthWordIfItExists(new List<string>());
            Assert.AreEqual(null, answer);
        }

        [TestMethod] 
        public void GetLastWordIfAny()
        {
            var answer = SingleValueExercise.GetLastWordIfAny("Watching the weather together with her".Split(' '));
            Assert.AreEqual("her", answer);

            answer = SingleValueExercise.GetLastWordIfAny("Watching the watcher alone".Split(' '));
            Assert.AreEqual("alone", answer);

            answer = SingleValueExercise.GetLastWordIfAny(new List<string>());
            Assert.AreEqual(null, answer);
        }
    }
}
