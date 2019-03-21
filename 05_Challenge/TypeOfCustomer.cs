using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{
    public enum InsuranceType
    {
        Current = 1, Past, Future
    }


    public class TypeOfCustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public InsuranceType TypeOfInsurance { get; set; }
        public string Email { get; set; }


        public TypeOfCustomer() { }
        public TypeOfCustomer(string firstName, string lastName, InsuranceType typeOfInsurance, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            TypeOfInsurance = typeOfInsurance;
            Email = email;

        }

    }
}
