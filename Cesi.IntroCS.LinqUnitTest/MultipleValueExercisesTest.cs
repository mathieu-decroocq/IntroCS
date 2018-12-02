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
    public class MultipleValueExercisesTest
    {
        [TestMethod]
        public void GetThirdFourthFifthItems()
        {
            var words = "This is the first test".Split(' ');
            var answer = MultipleValueExercises.GetThirdFourthFifthItems(words);
            var str = string.Join(", ", answer);
            Assert.AreEqual("the, first, test", str);

            words = "I'm sorry Dave I can't do that".Split(' ');
            answer = MultipleValueExercises.GetThirdFourthFifthItems(words);
            str = string.Join(", ", answer);
            Assert.AreEqual("Dave, I, can't", str);

  
            words = "640K should be enough for anybody".Split(' ');
            answer = MultipleValueExercises.GetThirdFourthFifthItems(words);
            str = string.Join(", ", answer);
            Assert.AreEqual("be, enough, for", str);
        }

        [TestMethod]
        public void GetStartThroughEnd()
        {
            var words = "This start is the end first test".Split(' ');
            var answer = MultipleValueExercises.GetStartThroughEnd(words);
            var str = string.Join(", ", answer);
            Assert.AreEqual("start, is, the", str);

            words = "start I'm sorry Dave end I can't do that".Split(' ');
            answer = MultipleValueExercises.GetStartThroughEnd(words);
            str = string.Join(", ", answer);
            Assert.AreEqual("start, I'm, sorry, Dave", str);

            words = "640K should be start end enough for anybody".Split(' ');
            answer = MultipleValueExercises.GetStartThroughEnd(words);
            str = string.Join(", ", answer);
            Assert.AreEqual("start", str);
        }
    }
}
