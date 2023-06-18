using AutoMapper;
using CleanArchitecture.TaskManager.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Application.Mappers
{
    public class TaskMapperProfile : Profile
    {
        public TaskMapperProfile()
        {
            CreateMap<TaskDTO, Task>();

            CreateMap<Task, TaskDTO>();
        }
    }
}
