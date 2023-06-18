using AutoMapper;
using CleanArchitecture.TaskManager.Application.DTOs;
using CleanArchitecture.TaskManager.Domain.DomainObjects.Entities;
using CleanArchitecture.TaskManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Application.Mappers
{
    public class ProjectMapperProfile : Profile
    {
        public ProjectMapperProfile()
        {
            CreateMap<ProjectDTO, Project>();
            CreateMap<Project, ProjectDTO>();
        }
    }
}
