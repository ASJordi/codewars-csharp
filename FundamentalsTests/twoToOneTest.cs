using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsTests
{
    [TestClass]
    public class twoToOneTest
    {
        [TestMethod]
        public void TestFixed()
        {
            Assert.AreEqual("aehrsty", Fundamentals.twoToOne.Longest("aretheyhere", "yestheyarehere"));
            Assert.AreEqual("abcdefghilnoprstu", Fundamentals.twoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Assert.AreEqual("acefghilmnoprstuy", Fundamentals.twoToOne.Longest("inmanylanguages", "theresapairoffunctions"));
            Assert.AreEqual("abcdefklmopqwxy", Fundamentals.twoToOne.Longest("xyaabbbccccdefww", "xxxxyyyyabklmopq"));
            Assert.AreEqual("abcdefghijklmnopqrstuvwxyz", Fundamentals.twoToOne.Longest("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz"));
        }
    }
}
