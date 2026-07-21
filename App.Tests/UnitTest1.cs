using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 2;
            int actual = 1 + 1;
            Assert.AreEqual(expected, actual, "Math should work correctly.");
        }
    }
}
