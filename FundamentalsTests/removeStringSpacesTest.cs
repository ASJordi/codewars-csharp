using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsTests
{
    [TestClass]
    public class removeStringSpacesTest
    {
        [TestMethod]
        public void TestFixed()
        {
            Assert.AreEqual("8j8mBliB8gimjB8B8jlB", Fundamentals.removeStringSpaces.NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B"));
            Assert.AreEqual("88Bifk8hB8BB8BBBB888chl8BhBfd", Fundamentals.removeStringSpaces.NoSpace("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"));
            Assert.AreEqual("8aaaaaddddr", Fundamentals.removeStringSpaces.NoSpace("8aaaaa dddd r     "));
        }
    }
}
