using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Login;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFalse()
        {
            User Clem = new User("Clement", "clement.c");
            Assert.AreEqual(false, Clem.VerifMail());
        }

        [TestMethod]
        public void TestTrue()
        {
            User Ad = new User("Adeline", "adeline.rochette@gmail.com");
            Assert.AreEqual(true, Ad.VerifMail());
        }
    }
}
