using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FundamentalsTests
{
    [TestClass]
    public class stringEndsWithTest
    {
        public static IEnumerable<object[]> sampleTestCases
        {
            get
            {
                return new[]
                {
                    new object[] {"samurai", "ai", true},
                    new object[] {"sumo", "omo", false},
                    new object[] {"ninja", "ja", true},
                    new object[] {"sensei", "i", true},
                    new object[] {"samurai", "ra", false},
                    new object[] {"abc", "abcd", false},
                    new object[] {"abc", "abc", true},
                    new object[] {"abcabc", "bc", true},
                    new object[] {"ails", "fails", false},
                    new object[] {"fails", "ails", true},
                    new object[] {"this", "fails", false},
                    new object[] {"abc", "", true},
                    new object[] {":-)", ":-(", false},
                    new object[] {"!@#$%^&*() :-)", ":-)", true},
                    new object[] {"abc\n", "abc", false},

                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(sampleTestCases))]
        public void SampleTest(string str, string ending, bool expected)
        {
            Assert.AreEqual(expected, Fundamentals.stringEndsWith.endsWith(str, ending));
        }
    }
}
