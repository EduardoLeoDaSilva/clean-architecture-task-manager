using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Common.Communication
{
    /// <summary>
    /// Message for implementing Notification pattern
    /// </summary>
    public class NotificationMessage : BaseMessage
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
