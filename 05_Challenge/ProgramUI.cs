using System;
using System.Collections.Generic;

namespace _05_Challenge
{
    //$"{menu, firstName, -7}
    public class ProgramUI
    {

        private EmailRepository _emailRepo = new EmailRepository();


        public void Run()
        {

            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Press the number of the option you would like to access\n" +
                    "1. Create a New Account.\n" +
                    "2. View Account\n" +
                    "3. Update Account\n" +
                    "4. Delete Account\n" +
                    "5. Exit Applicatoin");
                int inputAsString = int.Parse(Console.ReadLine());

                switch (inputAsString)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        ReadCustomerInfo();
                        break;
                    case 3:
                        UpdateCustomerInfo();
                        break;
                    case 4:
                        DeleteCustomerInfo();
                        break;
                    case 5:
                        running = false;
                        break;

                }
            }
        }
        public void AddCustomer()
        {
            TypeOfCustomer customer = new TypeOfCustomer();

            Console.WriteLine("What is your First Name?");
            customer.FirstName = Console.ReadLine();

            Console.WriteLine("What is your Last Name?");
            customer.LastName = Console.ReadLine();





            Console.WriteLine("Hello are you:\n" +
              "1. Current Customer.\n" +
              "2. Past Customer.\n" +
              "3. Potentially joining the Family.");

            int response = int.Parse(Console.ReadLine());


            if (response == 1)
            {
                customer.TypeOfInsurance = InsuranceType.Current;
                customer.Email = "Thank you for your work with us. We appreciate your loyalty. Here's a coupon.";
            }
            if (response == 2)
            {
                customer.TypeOfInsurance = InsuranceType.Future;
                customer.Email = "It's been a long time since we've heard from you, we want you back.";
            }
                if (response == 3)
            {
                customer.TypeOfInsurance = InsuranceType.Past;
                customer.Email = "We currently have the lowest rates on Helicopter Insurance!";
            }
            _emailRepo.AddCustomer(customer);
        }
        public void ReadCustomerInfo()
        {
            List<TypeOfCustomer> typeOfCustomers = _emailRepo.GetTypeOfCustomers();
            foreach (TypeOfCustomer customer in typeOfCustomers)
            {
                Console.WriteLine($"{customer.FirstName}{customer.LastName}{customer.TypeOfInsurance}{customer.Email}.");
            }
            Console.ReadLine();


        }
        public void UpdateCustomerInfo()
        {
            ReadCustomerInfo();
            Console.WriteLine("Would you like to Update your account:" +
                "1. Yes\n" +
                "2. No.");
            int number = int.Parse(Console.ReadLine());
            string firstName = null;
            string lastName = null;
            if (number == 1)
            {
                Console.WriteLine("Please enter your first name.");
                firstName = Console.ReadLine();
                Console.WriteLine("Please enter your last name.");
                lastName = Console.ReadLine();
                _emailRepo.RemoveUpdateCustomerBySpecifications(firstName, lastName);
                
            }
            else
            {
                Console.WriteLine("thanks come again.");
            }

            TypeOfCustomer customer = new TypeOfCustomer();

            customer.FirstName = firstName;
            customer.LastName = lastName;
            Console.WriteLine("Are you now a:" +
            "1. Current Customer.\n" +
            "2. Past Customer.\n" +
            "3. Potentially joining the Family.");

            int response = int.Parse(Console.ReadLine());


            if (response == 1)
            {
                customer.TypeOfInsurance = InsuranceType.Current;
                customer.Email = "Thank you for your work with us. We appreciate your loyalty. Here's a coupon.";
            }
            if (response == 2)
            {
                customer.TypeOfInsurance = InsuranceType.Future;
                customer.Email = "We currently have the lowest rates on Helicopter Insurance!";
            }
            if (response == 3)
            {
                customer.TypeOfInsurance = InsuranceType.Past;
                customer.Email = "It's been a long time since we've heard from you, we want you back.";
            }
            _emailRepo.AddCustomer(customer);
        }
        public void DeleteCustomerInfo()
        {
            ReadCustomerInfo();
            Console.WriteLine("Would you like to Delete your account:" +
                "1. Yes\n" +
                "2. No.");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("Please enter your first name.");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please enter your last name.");
                string lastName = Console.ReadLine();
                bool response = _emailRepo.RemoveUpdateCustomerBySpecifications(firstName, lastName);
                if (response == true)
                {
                    Console.WriteLine($"You have successfully delete {number} account.");
                }
                else
                {
                    Console.WriteLine($"Your account {number} has not been deleted.");
                }
            }
            else
            {
                Console.WriteLine("thanks come again.");
            }
        }
    }
}
