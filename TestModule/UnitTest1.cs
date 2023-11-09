using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Module_Test_Ampilogov_Igor;

namespace TestModule
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calc = new Skeleton(0, 25);
            var testres = 6;
            var res = calc.Costing();
            Assert.AreEqual(testres, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var calc = new Elephant(0, 30);
            var testres = 4;
            var res = calc.Costing();
            Assert.AreEqual(testres, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var calc = new Infantry(1, 3);
            var testres = 1;
            var res = calc.Costing();
            Assert.AreEqual(testres, res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var calc = new Skeleton(0, 25);
            var testres = 25;
            var res = calc.Speeding();
            Assert.AreEqual(testres, res);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var calc = new Elephant(0, 30);
            var testres = 30;
            var res = calc.Speeding();
            Assert.AreEqual(testres, res);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var calc = new Infantry(1, 3);
            var testres = 3;
            var res = calc.Speeding();
            Assert.AreEqual(testres, res);
        }

    }
}
