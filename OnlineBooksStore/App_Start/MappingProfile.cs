using AutoMapper;
using OnlineBooksStore.Dtos;
using OnlineBooksStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBooksStore.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}