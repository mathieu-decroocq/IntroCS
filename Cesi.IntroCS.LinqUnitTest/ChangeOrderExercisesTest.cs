using Cesi.IntroCS.LinqClassLibrary;
using Cesi.IntroCS.LinqClassLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Name = Cesi.IntroCS.LinqClassLibrary.Models.Name;

namespace Cesi.IntroCS.LinqUnitTest
{
    [TestClass]
    public class ChangeOrderExercisesTest
    {
        [TestMethod]
        public void SortNamesByLast()
        {
            var names = new List<IName>
            {
                new Name("Martin Luther King"),
                new Name("Johan Sebastian Bach"),
                new Name("Wolfgang Amadeus Mozart"),
                new Name("Franklin Delano Roosevelt")
            };


            var answer = ChangeOrderExercises.SortNamesByLast(names);

            var str = string.Join(", ", answer.Select(a => a.Last));
            Assert.AreEqual("Roosevelt, Mozart, King, Bach", str);


            names = new List<IName>
            {
                new Name("Hillary Rodham Clinton"),
                new Name("Edgar Allan Poe"),
                new Name("Billie Jean King"),
                new Name("John Fitzgerald Kennedy")
            };


            answer = ChangeOrderExercises.SortNamesByLast(names);

            str = string.Join(", ", answer.Select(a => a.Last));
            Assert.AreEqual("Poe, King, Kennedy, Clinton", str);
        }

        [TestMethod]
        public void SortNamesByLastAndFirstAndMiddle()
        {
            var names = new List<IName>
            {
                new Name("Johan Sebastian Bach"),
                new Name("Martin Luther King"),
                new Name("Billie Jean King"),
                new Name("Im The King"),
                new Name("Franklin Delano Roosevelt")
            };

            var answer = ChangeOrderExercises.SortNamesByLastAndFirstAndMiddle(names);
            var str = string.Join(", ", answer.Select(a => a.First));
            Assert.AreEqual("Johan, Billie, Im, Martin, Franklin", str);

            names = new List<IName>
            {
                new Name("Hillary Rodham Clinton"),
                new Name("Edgar Ellen Poe"),
                new Name("Edgar Allan Poe"),
                new Name("John Fitzgerald Kennedy")
            };

            answer = ChangeOrderExercises.SortNamesByLastAndFirstAndMiddle(names);
            str = string.Join(", ", answer.Select(a => a.Middle));
            Assert.AreEqual("Rodham, Fitzgerald, Allan, Ellen", str);
        }


    }
}
