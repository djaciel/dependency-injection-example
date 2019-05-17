using DemoDI.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDI.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();
    }
}
