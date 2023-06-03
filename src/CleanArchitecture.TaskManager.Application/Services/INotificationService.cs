using CleanArchitecture.TaskManager.Common.Communication;

namespace CleanArchitecture.TaskManager.Application.Services
{
    public interface INotificationService
    {
        void AddNotificationMessage(NotificationMessage message);
        NotificationMessage GetFinalNotification();
        bool IsValid();
    }
}