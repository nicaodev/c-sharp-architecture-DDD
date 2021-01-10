using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Infrastructure.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<UserEntity, UserModel>().ReverseMap();
        }
    }
}
