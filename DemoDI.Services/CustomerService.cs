using DemoDI.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDI.Services
{
    public class CustomerService : ICustomerService
    {
        private static List<Customer> customers = new List<Customer>()
        {
            new Customer(){ Id = 1, Name = "juan" },
            new Customer(){ Id = 2, Name = "pedro" },
            new Customer(){ Id = 3, Name = "luis" }
        };

        public IEnumerable<Customer> GetCustomers()
        {
            return customers;
        }
    }
}
