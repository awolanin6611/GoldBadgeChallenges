using System;
using _05_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_
{
    [TestClass]
    public class EmailRepository_Test
    {
        [TestMethod]
        public void AddAndGetItemsToEmailRepo_ShouldBeCorrect()
        {
            EmailRepository _emailRepo = new EmailRepository();

            TypeOfCustomer customer = new TypeOfCustomer();
            TypeOfCustomer customerTwo = new TypeOfCustomer();
            TypeOfCustomer customerThree = new TypeOfCustomer();

            _emailRepo.AddCustomer(customer);
            _emailRepo.AddCustomer(customerTwo);
            _emailRepo.AddCustomer(customerThree);

            int actual = _emailRepo.GetTypeOfCustomers().Count;
            int expected = 3;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void RemoveFromEmailList_ShouldBeCorrect()
        {

            EmailRepository _emailRepo = new EmailRepository();

            TypeOfCustomer customer = new TypeOfCustomer();
            TypeOfCustomer customerTwo = new TypeOfCustomer();
            TypeOfCustomer customerThree = new TypeOfCustomer();

            _emailRepo.AddCustomer(customer);
            _emailRepo.AddCustomer(customerTwo);
            _emailRepo.AddCustomer(customerThree);

            _emailRepo.RemoveCustomerDetail(customer);

            int actual = _emailRepo.GetTypeOfCustomers().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}
