﻿using AutoMapper;
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
            //Mappers for Domain to Dto objects
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Book, BookDto>();

            //Mappers for Dto to Domain Objects
            Mapper.CreateMap<BookDto, Book>().
                ForMember(b => b.Id, opt=> opt.Ignore());
            Mapper.CreateMap<CustomerDto, Customer>().
                ForMember(c => c.Id,opt => opt.Ignore());
        }
    }
}