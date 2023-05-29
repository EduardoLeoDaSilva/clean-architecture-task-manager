using CleanArchitecture.TaskManager.Common.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Common.Utils.Validators.Interfaces
{
    public interface IValidator
    {
        public NotificationMessage Validate();
    }
}
