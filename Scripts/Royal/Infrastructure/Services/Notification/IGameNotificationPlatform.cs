using UnityEngine;

namespace Royal.Infrastructure.Services.Notification
{
    public interface IGameNotificationPlatform
    {
        // Methods
        public abstract void ScheduleNotification(Royal.Infrastructure.Services.Notification.GameNotification notification); // 0
        public abstract void CancelNotification(int notificationId); // 0
        public abstract void DismissNotification(int notificationId); // 0
        public abstract void CancelAllScheduledNotifications(); // 0
        public abstract void DismissAllNotifications(); // 0
        public abstract System.Collections.IEnumerator RequestAuthorization(); // 0
    
    }

}
