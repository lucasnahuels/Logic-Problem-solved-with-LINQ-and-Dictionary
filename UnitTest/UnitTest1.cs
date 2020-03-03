using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThirdShot_TheListIsOrderedByTimes_ReturnTrue()
        {
            // Arrange
            short[] testNumbers = new short[] { 2, 2, 5, 6, 9, 4, 9, 3 };

            var result = new short[] { 9, 2, 6, 5, 4, 3 };

            // Assert
            CollectionAssert.AreEqual(result, OrderHelper.ThirdShot(testNumbers));
        }

        [TestMethod]
        public void ThirdShot_TheListIsOrderedByTimes_ReturnOnePosition()
        {
            // Arrange
            short[] testNumbers = new short[] { 1,1,1,1,1 };

            var result = new short[] {1};

            // Assert
            CollectionAssert.AreEqual(result, OrderHelper.ThirdShot(testNumbers));
        }

        [TestMethod]
        public void GetCorrectString_TheStringMustNotBeNull_ReturnArgumentException()
        {
            // Arrange
            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => OrderHelper.GetCorrectString(null)); 
        }

        [TestMethod]
        public void GetCorrectString_TheStringMustNotBeEmpty_ReturnArgumentException()
        {
            // Arrange
            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => OrderHelper.GetCorrectString(string.Empty));
        }

        [TestMethod]
        public void GetCorrectString_TheStringMustNotBeWhiteSpaces_ReturnArgumentException()
        {
            // Arrange
            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => OrderHelper.GetCorrectString(" "));
        }

        [TestMethod]
        public void GetCorrectString_TheNumberOfCharactersMustNotBeGreaterThan20_ReturnArgumentException()
        {
            // Arrange
            // Assert
            Assert.ThrowsException<ArgumentException>(() => OrderHelper.GetCorrectString("012345678901234567890123456789"));
        }

        [TestMethod]
        public void GetCorrectString_TheStringMessageMustNotBeValorNoPermitido_ReturnFalse()
        {
            // Arrange
            var result = OrderHelper.GetCorrectString("Valor no permitido");
            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetCorrectString_TheStringIsCorrect_ReturnTrue()
        {
            // Arrange
            var result= OrderHelper.GetCorrectString("0123456789");
            // Assert
            Assert.IsTrue(result);

        }
    }
}
