using AutoMapper;
using AutoMapperSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperSample
{
    internal class AutoMapperConfigurations : Profile
    {
        public AutoMapperConfigurations()
        {
            CreateMap<Order, OrderDto>().ReverseMap();

            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));
            CreateMap<CustomerDto, Customer>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Name.Split(' ', StringSplitOptions.None)[0] ?? ""))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Name.Split(' ', StringSplitOptions.None)[1] ?? ""));
        }
    }
}
