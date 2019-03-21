using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{
    public class EmailRepository
    {
        List<TypeOfCustomer> _customers = new List<TypeOfCustomer>();

        public void AddCustomer(TypeOfCustomer customers)
        {
            _customers.Add(customers);
        }
        public List<TypeOfCustomer> GetTypeOfCustomers()
        {
            return _customers;
        }
        public void RemoveCustomerDetail(TypeOfCustomer customers)
        {
            _customers.Remove(customers);
        }

        public bool RemoveUpdateCustomerBySpecifications(string firstName, string lastName)
        {
            bool successful = false;
            foreach (TypeOfCustomer customers in _customers)
            {
                if (customers.FirstName == firstName && customers.LastName == lastName)
                {
                    RemoveCustomerDetail(customers);
                    successful = true;
                    break;
                }
            }
            return successful;
        }
    }
}

