using AutoMapperSample;
using AutoMapperSample.Models;
using AutoMapperSample.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        ServiceCollection services = new ();
        services.AddAutoMapper(typeof(Program).Assembly);
        services.AddLogging(builder => builder.AddConsole());
        
        services.AddScoped<ICustomerService, CustomerService>();

        var provider = services.BuildServiceProvider();


        ICustomerService customerService = provider.GetService<ICustomerService>();
        var customerDtos = customerService.GetCustomers();

        var customerDto = new CustomerDto() { 
            Id = 3, 
            Name = "Arthur Curry", 
            City = "Atlantis", 
            Order = new OrderDto() { Id = 4, ItemName = "Cape", ItemColor= Color.Green }
        };

        customerDtos = customerService.AddCustomer(customerDto);



        Console.Read();
    }

    
}