using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var num1 = 2;
            var num2 = 3;
            var expected = 5;

            // Act
            var testManager = new testManager();
            var result = testManager.bla(num1, num2);

            // Assert
            Assert.AreEqual(expected,result);
        }
    }
}
