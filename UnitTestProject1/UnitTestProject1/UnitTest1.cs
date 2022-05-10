using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Login;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            User Clem = new User("Clement", "clement.c");
            Assert.AreEqual(false, Clem.verifMail());
        }

        [TestMethod]
        public void TestMethod2()
        {
            User Ad = new User("Adeline", "adeline.rochette@gmail.com");
            Assert.AreEqual(true, Ad.verifMail());
        }
    }
}
