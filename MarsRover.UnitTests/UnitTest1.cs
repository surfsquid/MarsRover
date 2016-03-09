using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRoverMovement()
        {

            //Test Input:
            //5 5
            //1 2 N
            //LMLMLMLMM
            //3 3 E
            //MMRMMRMRRM
            //Expected Output:
            //1 3 N
            //5 1 E

            // Arrange
            Rover testRover = new Rover();
            testRover.Initialize("1 2 N", "LMLMLMLMM");
            // Act
            testRover.Move();
            // Assert
            Assert.AreEqual("1 3 N", testRover.GetLocation());
        }
    }
}
