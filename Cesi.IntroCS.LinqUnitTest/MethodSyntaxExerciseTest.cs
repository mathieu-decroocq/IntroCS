﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cesi.IntroCS.LinqClassLibrary;

namespace Cesi.IntroCS.LinqUnitTest
{
    [TestClass]
    public class MethodSyntaxExerciseTest
    {
        [TestMethod]
        public void MethodFilterAndSort()
        {
            var answer = MethodSyntaxExercise.FilterAndSort(new List<string> { "foo", "bar", "goo", "onion" }, "oo");
            Assert.AreEqual("foo, goo", string.Join(", ", answer));

            answer = MethodSyntaxExercise.FilterAndSort(new List<string> { "abc", "bca", "cba", "aaa" }, "a");
            Assert.AreEqual("aaa, abc, bca, cba", string.Join(", ", answer));

            answer = MethodSyntaxExercise.FilterAndSort(new List<string> { "pointer", "reference", "structure", "integer" }, "er");
            Assert.AreEqual("integer, pointer, reference", string.Join(", ", answer));
        }
    }
}
