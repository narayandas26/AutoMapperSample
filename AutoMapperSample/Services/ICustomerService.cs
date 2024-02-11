using AutoMapperSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperSample.Services
{
    internal interface ICustomerService
    {
        IEnumerable<CustomerDto> GetCustomers();
        IEnumerable<CustomerDto> AddCustomer(CustomerDto customerDto);
    }
}
