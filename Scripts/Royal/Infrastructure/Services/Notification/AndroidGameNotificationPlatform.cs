using UnityEngine;

namespace Royal.Infrastructure.Services.Notification
{
    public class AndroidGameNotificationPlatform : IGameNotificationPlatform
    {
        // Fields
        private readonly Unity.Notifications.Android.AndroidNotificationChannel defaultNotificationChannel;
        
        // Methods
        public AndroidGameNotificationPlatform()
        {
            mem[1152921527555228728] = 2;
            mem[1152921527555228740] = 0;
            mem[1152921527555228732] = 0;
            this.defaultNotificationChannel = "channel_id";
            mem[1152921527555228712] = "Default Channel";
            mem[1152921527555228720] = "Generic notifications";
            mem[1152921527555228748] = 0;
        }
        public System.Collections.IEnumerator RequestAuthorization()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new AndroidGameNotificationPlatform.<RequestAuthorization>d__2();
        }
        public void ScheduleNotification(Royal.Infrastructure.Services.Notification.GameNotification gameNotification)
        {
            int val_1 = Unity.Notifications.Android.AndroidNotificationCenter.SendNotification(notification:  new Unity.Notifications.Android.AndroidNotification() {<Title>k__BackingField = gameNotification.<Title>k__BackingField, <Text>k__BackingField = gameNotification.<Text>k__BackingField, <SmallIcon>k__BackingField = "small_notification_icon", <FireTime>k__BackingField = new System.DateTime() {dateData = gameNotification.<FireTime>k__BackingField.dateData}, <LargeIcon>k__BackingField = "large_notification_icon", <ShouldAutoCancel>k__BackingField = false, <UsesStopwatch>k__BackingField = false, <GroupSummary>k__BackingField = false, <ShowTimestamp>k__BackingField = false, <ShowCustomTimestamp>k__BackingField = false, m_Color = new UnityEngine.Color(), m_RepeatInterval = new System.TimeSpan(), m_CustomTimestamp = new System.DateTime()}, channelId:  this.defaultNotificationChannel);
        }
        public void CancelNotification(int notificationId)
        {
            Unity.Notifications.Android.AndroidNotificationCenter.CancelScheduledNotification(id:  notificationId);
        }
        public void DismissNotification(int notificationId)
        {
            Unity.Notifications.Android.AndroidNotificationCenter.CancelDisplayedNotification(id:  notificationId);
        }
        public void CancelAllScheduledNotifications()
        {
            Unity.Notifications.Android.AndroidNotificationCenter.CancelAllScheduledNotifications();
        }
        public void DismissAllNotifications()
        {
            Unity.Notifications.Android.AndroidNotificationCenter.CancelAllNotifications();
        }
    
    }

}
