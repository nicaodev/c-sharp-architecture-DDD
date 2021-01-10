using Api.Domain.DTOs.User;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Infrastructure.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {

        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDto>().ReverseMap();
        }
    }
}