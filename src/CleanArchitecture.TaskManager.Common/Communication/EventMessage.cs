using CleanArchitecture.TaskManager.Common.Utils.Validators.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Common.Communication
{
    public abstract class EventMessage : BaseMessage, INotification, IValidator
    {
        public NotificationMessage Validate()
        {
            throw new NotImplementedException();
        }
    }
}
