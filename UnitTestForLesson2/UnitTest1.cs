using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_S2016_Lesson2;

namespace UnitTestForLesson2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addXandY()
        {
            //Arrange
            int x = 40;
            int y = 50;
            int expectedResult = 90;
            //Act
            int result = Program.addXandY(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void addYtoX()
        {
            //Arrange
            int x = 40;
            int y = 50;
            int expectedResult = 90;
            //Act
            int result = Program.addXandY(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
