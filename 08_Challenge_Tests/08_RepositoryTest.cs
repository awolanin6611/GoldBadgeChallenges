using System;
using _08_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Challenge_Tests
{
    [TestClass]
    public class _08_RepositoryTest
    {
        [TestMethod]
        public void AddDriverTooList_ShouldBeCorrect()
        {
            InsuranceRepository _driverData = new InsuranceRepository();

            DriverData driver = new DriverData();
            DriverData driverTwo = new DriverData();

            _driverData.AddDriverToList(driver);
            _driverData.AddDriverToList(driverTwo);

            int actual = _driverData.GetDriverData().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void DriverInsurance_ShouldBeCorrect()
        {
            InsuranceRepository driverInfo = new InsuranceRepository();

            DriverData driver = new DriverData();
            DriverData driverTwo = new DriverData();
            driver.OverTheLimit = 100;
            driverTwo.OverTheLimit = 101;

            decimal actual = driverInfo.DriverInsruance(driver);
            decimal actualTwo = driverInfo.DriverInsruance(driverTwo);

            decimal expected = 200.00m;
            decimal expectedTwo = 200.00m;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedTwo, actualTwo);


        }
    }
}
