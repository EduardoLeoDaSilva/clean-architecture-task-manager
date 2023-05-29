using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Common.Communication
{
    public abstract class BaseMessage
    {

        public Guid Id { get; private set; }
        public DateTime CreatedTime { get; set; }
        public string Type { get; set; }
        public Dictionary<string, string> AdditionalInfo { get; set; }

        public BaseMessage()
        {
            Id = Guid.NewGuid();
            CreatedTime = DateTime.Now;
            Type = this.GetType().Name;
        }

    }
}
