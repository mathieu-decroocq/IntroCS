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
    public class CalculatedSequenceExercisesTest
    {
        [TestMethod]
        public void DisplayStringsForNames()
        {
            var names = new List<IName>
            {
                new Name("Martin Luther King"),
                new Name("Johan Sebastian Bach"),
                new Name("Wolfgang Amadeus Mozart"),
                new Name("Franklin Delano Roosevelt")
            };
        
            var answer = CalculatedSequenceExercises.DisplayStringsForNames(names);
            var str = string.Join("; ", answer);
            Assert.AreEqual("King, Martin; Bach, Johan; Mozart, Wolfgang; Roosevelt, Franklin", str);

            
            names = new List<IName>
            {
                new Name("Hillary Rodham Clinton"),
                new Name("Edgar Allan Poe"),
                new Name("Billie Jean King"),
                new Name("John Fitzgerald Kennedy")
            };
       
            answer = CalculatedSequenceExercises.DisplayStringsForNames(names);
            str = string.Join("; ", answer);
            Assert.AreEqual("Clinton, Hillary; Poe, Edgar; King, Billie; Kennedy, John", str);
        }

    }
}
