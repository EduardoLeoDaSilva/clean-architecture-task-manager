using CleanArchitecture.TaskManager.Common.Communication;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Application.UseCases.TaskManager.Queries
{
    public class GetProjectsProgressQuery : CommandMessage
    {
        public Guid? Id { get; set; }
        public int Size { get; set; }
        public int Offset { get; set; }
    }
}
