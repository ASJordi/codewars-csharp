using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsTests
{
    [TestClass]
    public class stringRepeatTest
    {
        [TestMethod]
        public void TestFixed()
        {
            Assert.AreEqual("***", Fundamentals.stringRepeat.RepeatStr(3, "*"));
            Assert.AreEqual("#####", Fundamentals.stringRepeat.RepeatStr(5, "#"));
            Assert.AreEqual("ha ha ", Fundamentals.stringRepeat.RepeatStr(2, "ha "));
        }
    }
}
