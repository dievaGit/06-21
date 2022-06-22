using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ValidString;

namespace UnitTestValidString
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestValidatingString()
        {
            string s = "ed(gg))hg(";
            string solution1 = StringValidating(s);
            string solution2 = "ed(gg)hg";
            Assert.AreEqual(solution1, solution2);
        }
    }
}
