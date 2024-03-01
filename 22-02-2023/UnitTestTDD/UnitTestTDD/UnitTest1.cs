using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathsLibrary;

namespace UnitTestTDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            Maths maths = new Maths();
            int result = maths.Add(1, 2);
            Assert.AreEqual(3, result);
        }
    }
}
