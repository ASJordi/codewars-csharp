using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FundamentalsTests
{
    [TestClass]
    public class phoneNumberTest
    {
        [TestMethod]
        public void TestFixed()
        {
            int[] numberOne = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[]numberTwo = { 1,1,1,1,1,1,1,1,1,1};
            string resultOne = Fundamentals.phoneNumber.CreatePhoneNumber(numberOne);
            string resultTwo = Fundamentals.phoneNumber.CreatePhoneNumber(numberTwo);

            Assert.AreEqual("(123) 456-7890", resultOne);
            Assert.AreEqual("(111) 111-1111", resultTwo);
        }
    }
}
