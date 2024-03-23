using AutoMapper;
using Project.Application.DTOs;
using Project.Application.Features.CustomerFeatures.Commands;
using Project.Application.Models;
using Project.Domail.Entities;

namespace Project.Application.Mapper
{
    public class CustomerMappingProfile : Profile
    {
        public CustomerMappingProfile() 
        {
            CreateMap<Customer, CustomerModel>().ReverseMap();
            CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
            CreateMap<Customer, UpdateCustomerCommand>().ReverseMap();
            CreateMap<Customer, CustomerDTO>().ReverseMap();
        }
    }
}
