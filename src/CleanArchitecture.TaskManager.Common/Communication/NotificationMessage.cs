using MediatR;
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
    public class NotificationMessage : BaseMessage, INotification
    {
        public string Message { get; private set; }
        public bool Success { get; private set; } = true;
        public List<string> Errors { get; private set; } = new List<string>();

        public void AddErrors(string error)
        {
            this.Success = false;
            this.Errors.Add(error);
        }

        public static NotificationMessage CreateValidNotification()
        {
            return new NotificationMessage();
        }

        public static NotificationMessage CreateInvalidNotification()
        {
            return new NotificationMessage { Success = false };

        }

        public static NotificationMessage CreateInvalidNotification(string error)
        {
            var notification = new NotificationMessage();
            notification.Errors.Add(error);
            return notification;

        }

        public static NotificationMessage CreateInvalidNotification(params string[] error)
        {
            var notification = new NotificationMessage();
            notification.Errors.AddRange(error);
            return notification;

        }
    }
}
