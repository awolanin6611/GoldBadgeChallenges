using System;
using _06_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Challenge_UnitTest
{
    [TestClass]
    public class CarRepository_Test_ShouldBeCorrect
    {
        [TestMethod]
        public void AddElectricCar_ShouldBeCorrect()
        {
            CarRepository _electricCar = new CarRepository();

            TypeOfCar electric = new TypeOfCar();
            TypeOfCar electricTwo = new TypeOfCar();

            _electricCar.AddElectricCar(electric);
            _electricCar.AddElectricCar(electricTwo);

            int actual = _electricCar.GetElectricCars().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void RemoveElectricCar_ShouldBeCorrect()
        {
            CarRepository _electricCar = new CarRepository();

            TypeOfCar electric = new TypeOfCar();
            TypeOfCar electricTwo = new TypeOfCar();

            _electricCar.AddElectricCar(electric);
            _electricCar.AddElectricCar(electricTwo);

            _electricCar.RemoveElectricCarInformation(electric);

            int actual = _electricCar.GetElectricCars().Count;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddHybridCar_ShouldBeCorrect()
        {
            CarRepository _hybridCar = new CarRepository();

            TypeOfCar hybrid = new TypeOfCar();
            TypeOfCar hybridTwo = new TypeOfCar();

            _hybridCar.AddHybridCar(hybrid);
            _hybridCar.AddHybridCar(hybridTwo);

            int actual = _hybridCar.HybridCars().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveHybridCar_ShouldBeCorrect()
        {
            CarRepository _hybridCar = new CarRepository();

            TypeOfCar hybrid = new TypeOfCar();
            TypeOfCar hybridTwo = new TypeOfCar();

            _hybridCar.AddHybridCar(hybrid);
            _hybridCar.AddHybridCar(hybridTwo);

            _hybridCar.RemoveHybridCarInformation(hybrid);

            int actual = _hybridCar.HybridCars().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddGasCar_ShouldBeCorrect()
        {

            CarRepository _gasCar = new CarRepository();

            TypeOfCar gasCar = new TypeOfCar();
            TypeOfCar garCarTwo = new TypeOfCar();

            _gasCar.AddGasCar(gasCar);
            _gasCar.AddGasCar(garCarTwo);

            int actual = _gasCar.GasCars().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveGasCar_ShouldBeCorrect()
        {
            CarRepository _gasCar = new CarRepository();

            TypeOfCar gasCar = new TypeOfCar();
            TypeOfCar garCarTwo = new TypeOfCar();

            _gasCar.AddGasCar(gasCar);
            _gasCar.AddGasCar(garCarTwo);

            _gasCar.RemoveGasCarInformation(gasCar);

            int actual = _gasCar.GasCars().Count;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }
    }
}
