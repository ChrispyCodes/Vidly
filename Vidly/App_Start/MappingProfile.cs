using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.DTOs;
using Vidly.Models;
using AutoMapper;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDTO>();
            Mapper.CreateMap<CustomerDTO, Customer>();
            Mapper.CreateMap<MembershipType, MembershipTypeDTO>();
            Mapper.CreateMap<Movie, MovieDTO>();
            Mapper.CreateMap<Genre, GenreTypeDTO>();
            Mapper.CreateMap<Rental, RentalDTO>();


            Mapper.CreateMap<Customer, CustomerDTO>().ReverseMap().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<Movie, MovieDTO>().ReverseMap().ForMember(m => m.Id, opt => opt.Ignore());

        }
    }
}