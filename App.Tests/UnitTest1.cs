using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool someResult;

            Assert.IsFalse(someResult);
            Assert.IsTrue(someResult);
            Assert.IsTrue(someResult);
            Assert.IsFalse(someResult);
            Assert.Fail("Should not reach this line!");
            Assert.Fail("Should not reach this line!");
        }
    }
}
