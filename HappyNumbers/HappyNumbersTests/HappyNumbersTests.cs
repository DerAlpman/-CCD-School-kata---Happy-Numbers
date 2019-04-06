using System;
using HappyNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HappyNumbersTests
{
    [TestClass]
    public class HappyNumbersTests
    {
        [TestMethod]
        [DataRow(19)]
        [DataRow(23)]
        [DataRow(188)]
        [DataRow(464)]
        [DataRow(761)]
        public void IsHappyNumber_HappyNumber_ReturnsTrue(int numberToCheck)
        {
            #region ARRANGE

            #endregion

            #region ACT

            bool result = HappyNumberChecker.IsHappyNumber(numberToCheck);

            #endregion

            #region ASSERT

            Assert.IsTrue(result);

            #endregion
        }
    }
}
