using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrumBoardLib.Model;
using System;

namespace ScrumBoardTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(0)]
        [DataRow(19)]
        public void TestMethod1(int value)
        {
            // Arrange
            UserStory us = new UserStory();
            int expectedValue = value;

            // Act
            us.StoryPoints = value;

            int actualValue = us.StoryPoints;

            // Assert
            Assert.AreEqual(actualValue, expectedValue);

        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(-1021)]
        public void TestMethod2(int value)
        {
            // Arrange
            UserStory us = new UserStory();


            // Act


            // Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => us.StoryPoints = value);

        }
    }
}
