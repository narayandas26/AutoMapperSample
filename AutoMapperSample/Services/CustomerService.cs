using AutoMapper;
using AutoMapperSample.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperSample.Services
{
    internal class CustomerService(IMapper mapper, ILogger<CustomerService> logger) : ICustomerService
    {
        //private IMapper _mapper;

        //public CustomerService(IMapper mapper)
        //{
        //    _mapper = mapper;
        //}

        IEnumerable<Customer> customers = new List<Customer>()
            {
                new Customer(){
                    Id = 1,
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    City = "Gotham City",
                    Order = new Order() { Id = 1, ItemName="Cape", ItemColor=AutoMapperSample.Color.Black}
                },
                new Customer(){
                    Id = 2,
                    FirstName = "Clark",
                    LastName = "Kent",
                    City = "Crypton",
                    Order = new Order() { Id = 2, ItemName="Cape", ItemColor=AutoMapperSample.Color.Red}
                }
            };

        public IEnumerable<CustomerDto> GetCustomers()
        {
            logger.LogInformation("Customer Entities Fetced..");

            return customers.Select(c => mapper.Map<CustomerDto>(c));
        }

        public IEnumerable<CustomerDto> AddCustomer(CustomerDto customerDto)
        {
            customers = customers.Append(mapper.Map<Customer>(customerDto));

            logger.LogInformation("CustomerDto Reverse mapped and added to Customer Set..");

            return customers.Select(c => mapper.Map<CustomerDto>(c));
        }

    }
}
