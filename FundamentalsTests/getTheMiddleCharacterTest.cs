using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsTests
{
    [TestClass]
    public class getTheMiddleCharacterTest
    {
        [TestMethod]
        public void GenericTests()
        {
            Assert.AreEqual("es", Fundamentals.getTheMiddleCharacter.GetMiddle("test"));
            Assert.AreEqual("t", Fundamentals.getTheMiddleCharacter.GetMiddle("testing"));
            Assert.AreEqual("dd", Fundamentals.getTheMiddleCharacter.GetMiddle("middle"));
            Assert.AreEqual("A", Fundamentals.getTheMiddleCharacter.GetMiddle("A"));
        }
    }
}
