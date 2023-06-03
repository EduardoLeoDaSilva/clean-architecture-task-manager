using CleanArchitecture.TaskManager.Common.Communication;

namespace CleanArchitecture.TaskManager.Application.Services
{
    public class NotificationService : INotificationService
    {
        private List<NotificationMessage> Notifications;

        public NotificationService()
        {
            this.Notifications = new List<NotificationMessage>();
        }

        public bool IsValid()
        {
            return Notifications.All(x => x.Success);
        }

        public NotificationMessage GetFinalNotification()
        {
            if (IsValid())
                return NotificationMessage.CreateValidNotification();

            return NotificationMessage
                .CreateInvalidNotification(this.Notifications.Select(x => x.Message).ToArray());
        }

        public void AddNotificationMessage(NotificationMessage message)
        {
            this.Notifications.Add(message);
        }
    }
}
