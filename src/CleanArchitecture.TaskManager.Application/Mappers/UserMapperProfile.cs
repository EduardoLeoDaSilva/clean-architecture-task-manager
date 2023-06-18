using AutoMapper;
using CleanArchitecture.TaskManager.Application.DTOs;
using CleanArchitecture.TaskManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Application.Mappers
{
    public class UserMapperProfile : Profile
    {

        public UserMapperProfile()
        {
            CreateMap<UserDTO, User>();

            CreateMap<User, UserDTO>();
        }

    }
}
