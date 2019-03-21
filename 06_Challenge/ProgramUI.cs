using System;
using System.Collections.Generic;

namespace _06_Challenge
{
    public class ProgramUI
    {
        
        private CarRepository _carRepo = new CarRepository();
       

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What kind of car are we looking at:\n" +
                   "1: Electric\n" +
                   "2: Hybrid\n" +
                   "3: Gas\n" +
                   "4: Exit");

                int inputAsString = int.Parse(Console.ReadLine());

                switch (inputAsString)
                {
                    case 1:
                        ElectricCar();
                        break;
                    case 2:
                        HybridCar();
                        break;
                    case 3:
                        GasCar();
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }



        public void ElectricCar()
        {
            Console.WriteLine("What would you like to do with Electric Car:\n" +
                "1: Add New Car.\n" +
                "2: Update Car.\n" +
                "3: Remove Car.\n" +
                "4: View List");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    AddNewElectricCar();
                    break;
                case 2:
                    UpdateElectricCar();
                    break;
                case 3:
                    RemoveElectricCar();
                    break;
                case 4:
                    ViewElectricCars();
                    break;
            }


        }
        public void AddNewElectricCar()
        {
            TypeOfCar electric = new TypeOfCar();

            Console.WriteLine("What is the Make of you car?");
            electric.CarType = Console.ReadLine();

            Console.WriteLine("What is the Color of your car?");
            electric.CarColor = Console.ReadLine();

            Console.WriteLine("What is the Year of your car?");
            electric.YearOfCar = int.Parse(Console.ReadLine());


            _carRepo.AddElectricCar(electric);
        }
        public void UpdateElectricCar()
        {
            ViewElectricCars();
            Console.WriteLine("Would you like to Update your account:" +
                "1. Yes\n" +
                "2. No.");
            int number = int.Parse(Console.ReadLine());
            string carType = null;
            string carColor = null;
            int carYear= 0;
            if (number == 1)
            {
                Console.WriteLine("Please Enter the Make of the car.");
                carType = Console.ReadLine();
                Console.WriteLine("Please Enter the Color of the car");
                carColor = Console.ReadLine();
                Console.WriteLine("Please Enter Car Year.");
                carYear = int.Parse(Console.ReadLine());

                _carRepo.RemoveUpdateElectricCarBySpecifications(carType, carColor, carYear);

            }
            else
            {
                Console.WriteLine("thanks come again.");
            }

           TypeOfCar electric = new TypeOfCar();

            electric.CarType = carType;
            electric.CarType = carColor;
            electric.YearOfCar = carYear;
            Console.WriteLine("What is the Make of you car?");
            electric.CarType = Console.ReadLine();

            Console.WriteLine("What is the Color of your car?");
            electric.CarColor = Console.ReadLine();

            Console.WriteLine("What is the Year of your car?");
            electric.YearOfCar = int.Parse(Console.ReadLine());

            _carRepo.AddElectricCar(electric);
        }
        public void RemoveElectricCar()
        {
            Console.WriteLine("Would you like to delete this car?\n" +
               "1: Yes\n" +
               "2: No");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("Please Enter the Make of the car.");
                string carType = Console.ReadLine();
                Console.WriteLine("Please Enter the Color of the car");
                string carColor = Console.ReadLine();
                Console.WriteLine("Please Enter Car Year.");
                int carYear = int.Parse(Console.ReadLine());
                bool response = _carRepo.RemoveUpdateElectricCarBySpecifications(carType, carColor, carYear);
            }
        }
        public void ViewElectricCars()
        {
            List<TypeOfCar> electricCar = _carRepo.GetElectricCars();
            foreach(TypeOfCar typeOfCar in electricCar)
            {
                Console.WriteLine($"{typeOfCar.CarType}\n" +
                    $"{typeOfCar.CarColor}\n" +
                    $"{typeOfCar.YearOfCar}");
            }
            Console.ReadLine();

        }
        public void HybridCar()
        {
            Console.WriteLine("What would you like to do with Electric Car:\n" +
                "1: Add New Car.\n" +
                "2: Update Car.\n" +
                "3: Remove Car.");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    AddNewHybridCar();
                    break;
                case 2:
                    UpdateHybridCar();
                    break;
                case 3:
                    RemoveHybridCar();
                    break;
                case 4:
                    ViewHybridCars();
                    break;
            }

        }
        public void AddNewHybridCar()
        {
            TypeOfCar hybridCar = new TypeOfCar();

            Console.WriteLine("What is the Make of you car?");
            hybridCar.CarType = Console.ReadLine();

            Console.WriteLine("What is the Color of your car?");
            hybridCar.CarColor = Console.ReadLine();

            Console.WriteLine("What is the Year of your car?");
            hybridCar.YearOfCar = int.Parse(Console.ReadLine());


            _carRepo.AddHybridCar(hybridCar);
        }
        public void UpdateHybridCar()
        {
            ViewHybridCars();
            Console.WriteLine("Would you like to Update your account:" +
                "1. Yes\n" +
                "2. No.");
            int number = int.Parse(Console.ReadLine());
            string carType = null;
            string carColor = null;
            int carYear = 0;
            if (number == 1)
            {
                Console.WriteLine("Please Enter the Make of the car.");
                carType = Console.ReadLine();
                Console.WriteLine("Please Enter the Color of the car");
                carColor = Console.ReadLine();
                Console.WriteLine("Please Enter Car Year.");
                carYear = int.Parse(Console.ReadLine());

                _carRepo.RemoveUpdateHybridCarBySpecifications(carType, carColor, carYear);

            }
            else
            {
                Console.WriteLine("thanks come again.");
            }

            TypeOfCar hybrid = new TypeOfCar();

            hybrid.CarType = carType;
            hybrid.CarType = carColor;
            hybrid.YearOfCar = carYear;
            Console.WriteLine("What is the Make of you car?");
            hybrid.CarType = Console.ReadLine();

            Console.WriteLine("What is the Color of your car?");
            hybrid.CarColor = Console.ReadLine();

            Console.WriteLine("What is the Year of your car?");
            hybrid.YearOfCar = int.Parse(Console.ReadLine());

            _carRepo.AddHybridCar(hybrid);
        }
        public void RemoveHybridCar()
        {
            Console.WriteLine("Would you like to delete this car?\n" +
                "1: Yes\n" +
                "2: No");
            int number = int.Parse(Console.ReadLine());
            if(number == 1)
            {
                Console.WriteLine("Please Enter the Make of the car.");
                string carType = Console.ReadLine();
                Console.WriteLine("Please Enter the Color of the car");
                string carColor = Console.ReadLine();
                Console.WriteLine("Please Enter Car Year.");
                int carYear = int.Parse(Console.ReadLine());
                bool response = _carRepo.RemoveUpdateHybridCarBySpecifications(carType,carColor, carYear);
            }
            else
            {
                Console.WriteLine("thanks come again.");
            }

        }
        public void ViewHybridCars()
        {
            List<TypeOfCar> hybridCar = _carRepo.HybridCars();
            foreach (TypeOfCar typeOfCar in hybridCar)
            {
                Console.WriteLine($"{typeOfCar.CarType}\n" +
                    $"{typeOfCar.CarColor}\n" +
                    $"{typeOfCar.YearOfCar}");
            }
            Console.ReadLine();
        }
        public void GasCar()
        {
            Console.WriteLine("What would you like to do with Electric Car:\n" +
                "1: Add New Car.\n" +
                "2: Update Car.\n" +
                "3: Remove Car.");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    AddNewGasCar();
                    break;
                case 2:
                    UpdateGasCar();
                    break;
                case 3:
                    RemoveGasCar();
                    break;
                case 4:
                    ViewGasCars();
                    break;
            }
        }

        public void AddNewGasCar()
        {
            TypeOfCar gasCar = new TypeOfCar();

            Console.WriteLine("What is the Make of you car?");
            gasCar.CarType = Console.ReadLine();

            Console.WriteLine("What is the Color of your car?");
            gasCar.CarColor = Console.ReadLine();

            Console.WriteLine("What is the Year of your car?");
            gasCar.YearOfCar = int.Parse(Console.ReadLine());


            _carRepo.AddGasCar(gasCar);
        }
        public void UpdateGasCar()
        {
            ViewElectricCars();
            Console.WriteLine("Would you like to Update your account:" +
                "1. Yes\n" +
                "2. No.");
            int number = int.Parse(Console.ReadLine());
            string carType = null;
            string carColor = null;
            int carYear = 0;
            if (number == 1)
            {
                Console.WriteLine("Please Enter the Make of the car.");
                carType = Console.ReadLine();
                Console.WriteLine("Please Enter the Color of the car");
                carColor = Console.ReadLine();
                Console.WriteLine("Please Enter Car Year.");
                carYear = int.Parse(Console.ReadLine());

                _carRepo.RemoveUpdateGasCarBySpecifications(carType, carColor, carYear);

            }
            else
            {
                Console.WriteLine("thanks come again.");
            }

            TypeOfCar gas = new TypeOfCar();

            gas.CarType = carType;
            gas.CarType = carColor;
            gas.YearOfCar = carYear;
            Console.WriteLine("What is the Make of you car?");
            gas.CarType = Console.ReadLine();

            Console.WriteLine("What is the Color of your car?");
            gas.CarColor = Console.ReadLine();

            Console.WriteLine("What is the Year of your car?");
            gas.YearOfCar = int.Parse(Console.ReadLine());

            _carRepo.AddElectricCar(gas);
        }
        public void RemoveGasCar()
        {
            Console.WriteLine("Would you like to delete this car?\n" +
               "1: Yes\n" +
               "2: No");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("Please Enter the Make of the car.");
                string carType = Console.ReadLine();
                Console.WriteLine("Please Enter the Color of the car");
                string carColor = Console.ReadLine();
                Console.WriteLine("Please Enter Car Year.");
                int carYear = int.Parse(Console.ReadLine());
                bool response = _carRepo.RemoveUpdateGasCarBySpecifications(carType, carColor, carYear);
            }
            else
            {
                Console.WriteLine("thanks come again.");
            }
        }
        public void ViewGasCars()
        {
            List<TypeOfCar> gasCar = _carRepo.GasCars();
            foreach (TypeOfCar typeOfCar in gasCar)
            {
                Console.WriteLine($"{typeOfCar.CarType}\n" +
                    $"{typeOfCar.CarColor}\n" +
                    $"{typeOfCar.YearOfCar}");
            }
            Console.ReadLine();
        }

    }

}

