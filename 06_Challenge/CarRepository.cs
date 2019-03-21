using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Challenge
{
    public class CarRepository
    {
        List<TypeOfCar> _electricCar = new List<TypeOfCar>();
       
        public void AddElectricCar(TypeOfCar electricCar)
        {
            _electricCar.Add(electricCar);
        }
        public List<TypeOfCar> GetElectricCars()
        {
            return _electricCar;
        }
        public void RemoveElectricCarInformation(TypeOfCar electricCar)
        {
            _electricCar.Remove(electricCar);
        }

        public bool RemoveUpdateElectricCarBySpecifications(string carType, string carColor, int yearOfCar)
        {
            bool successful = false;
            foreach (TypeOfCar electriceCar in _electricCar)
            {
                if (electriceCar.CarType == carType && electriceCar.CarColor == carColor && electriceCar.YearOfCar == yearOfCar)
                {
                    RemoveElectricCarInformation(electriceCar);
                    successful = true;
                    break;
                }
            }
            return successful;
        }

        List<TypeOfCar> _hybridCar = new List<TypeOfCar>();

        public void AddHybridCar(TypeOfCar hybridCar)
        {
            _hybridCar.Add(hybridCar);
        }
        public List<TypeOfCar> HybridCars()
        {
            return _hybridCar;
        }
        public void RemoveHybridCarInformation(TypeOfCar hybridCar)
        {
            _electricCar.Remove(hybridCar);
        }

        public bool RemoveUpdateHybridCarBySpecifications(string carType, string carColor, int yearOfCar)
        {
            bool successful = false;
            foreach (TypeOfCar hybridCar in _hybridCar)
            {
                if (hybridCar.CarType == carType && hybridCar.CarColor == carColor && hybridCar.YearOfCar == yearOfCar)
                {
                    RemoveHybridCarInformation(hybridCar);
                    successful = true;
                    break;
                }
            }
            return successful;
        }

        List<TypeOfCar> _gasCar = new List<TypeOfCar>();

        public void AddGasCar(TypeOfCar gasCar)
        {
            _gasCar.Add(gasCar);
        }
        public List<TypeOfCar> GasCars()
        {
            return _gasCar;
        }
        public void RemoveGasCarInformation(TypeOfCar gasCar)
        {
            _gasCar.Remove(gasCar);
        }

        public bool RemoveUpdateGasCarBySpecifications(string carType, string carColor, int yearOfCar)
        {
            bool successful = false;
            foreach (TypeOfCar gasCar in _gasCar)
            {
                if (gasCar.CarType == carType && gasCar.CarColor == carColor && gasCar.YearOfCar == yearOfCar)
                {
                    RemoveGasCarInformation(gasCar);
                    successful = true;
                    break;
                }
            }
            return successful;
        }
    }
}
