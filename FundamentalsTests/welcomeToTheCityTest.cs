using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsTests
{
    [TestClass]
    public class welcomeToTheCityTest
    {
        [TestMethod]
        public void TestFIxed()
        {
            Assert.AreEqual("Hello, John Smith! Welcome to Phoenix, Arizona!", Fundamentals.welcomeToTheCity.SayHello(new string[] { "John", "Smith" }, "Phoenix", "Arizona"));
        }
    }
}
