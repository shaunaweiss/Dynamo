using System;
using Helper.External.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_UserClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void User_BMI_GetDifference()
        {
            //arrange
            User test1 = new User();
            test1._currentweight = 160;
            test1._height = 60;
            test1._targetweight = 145;

            double expectedBMI = 31;
            double expectedDiff = 15;


            //act
            double actualBMI = test1.BMI;
            double actualDiff = test1.getDifferencce;

            //assert
            Assert.AreEqual(actualBMI, expectedBMI);
            Assert.AreEqual(actualDiff, expectedDiff);

        }
    }
}
