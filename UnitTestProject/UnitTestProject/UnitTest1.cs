using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Add()
        {
            My_Math my_Math = new My_Math();

            int result = my_Math.Add(1, 2);

            Assert.AreEqual(result, 3);
        }
    }
}
