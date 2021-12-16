using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestProject {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            string[] s = { "HelpBank", "130", "100", "1000", "1000" };
            var f = new GeneralForm(s);
            string res2 = f.test();
            string one = string.Join(Convert.ToString(' '), s);



            Assert.AreEqual(one, res2);
        }

        public void TestMethod2()
        {
            string[] s = { "1222", "130", "100", "1000", "1000" };
            var f = new GeneralForm(s);
            string res2 = f.test();
            string one = string.Join(Convert.ToString(' '), s);



            Assert.AreEqual(one, res2);
        }
    }
}
