using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test_AssignmentClass_1()
        {
            AssignmentClass assignmentClass = new AssignmentClass();
            int input = 33;

            string result = assignmentClass.greadCalculate(input);
            Assert.AreEqual("F", result);
        }

        [TestMethod]
        public void Test_AssignmentClass_2()
        {
            AssignmentClass assignmentClass = new AssignmentClass();
            double relult = assignmentClass.getDistance(3, 2, 7, 8);
            Assert.AreEqual(7.21, relult);
            relult = assignmentClass.getDistance(-3, 2, 7, -8);
            Assert.AreEqual(14.14, relult);
            relult = assignmentClass.getDistance(-3, -2, -7, -8);
            Assert.AreEqual(7.21, relult);
            relult = assignmentClass.getDistance(3, -2, -7, 8);
            Assert.AreEqual(14.14, relult);
        }

        [TestMethod]
        public void Test_AssignmentClass_3()
        {
            AssignmentClass assignmentClass = new AssignmentClass();
            int relult = assignmentClass.getFactorial(3);
            Assert.AreEqual(6, relult);
        }

        [TestMethod]
        public void Test_AssignmentClass_4()
        {

            AssignmentClass checker = new AssignmentClass();
            string Password1 = "abc";
            int Password2 = 12345678;

            string Password22 = Convert.ToString(Password2);

            bool password = checker.checkPassword(Password1, Password22);
            Assert.AreEqual(true, password);
        }
    }
}
