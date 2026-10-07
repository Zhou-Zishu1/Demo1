using System;
using System.Collections.Generic;

namespace CMS.BusinessLayer
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "test@test.com";
                customer.FirstName = "Ivan";
                customer.LastName = "Ivanov";
            }
            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save(Customer customer)
        {
            if (customer.Validate())
            {
                return true;
            }
            return false;
        }
    }
}
