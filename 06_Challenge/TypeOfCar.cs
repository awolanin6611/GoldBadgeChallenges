using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Challenge
{
    public enum FuelType
    {
        Electric = 1, Hybrid, Gas
    }

    public class TypeOfCar
    {
        public string CarType { get; set; }
        public string CarColor { get; set; }
        public FuelType TypeOfFuel { get; set; }
        public int YearOfCar { get; set; }

        public TypeOfCar(){}
        public TypeOfCar(string carType, string carColor, FuelType typeOfFuel, int yearOfCar)
        {
            CarType = carType;
            CarColor = carColor;
            TypeOfFuel = typeOfFuel;
            YearOfCar = yearOfCar;
        }
    }
}
