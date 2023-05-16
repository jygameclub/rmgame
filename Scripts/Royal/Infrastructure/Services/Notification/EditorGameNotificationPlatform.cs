using UnityEngine;

namespace Royal.Infrastructure.Services.Notification
{
    public class EditorGameNotificationPlatform : IGameNotificationPlatform
    {
        // Methods
        public System.Collections.IEnumerator RequestAuthorization()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new EditorGameNotificationPlatform.<RequestAuthorization>d__0();
        }
        public void ScheduleNotification(Royal.Infrastructure.Services.Notification.GameNotification notification)
        {
            object[] val_1 = new object[1];
            val_1[0] = notification.<Title>k__BackingField;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Scheduled notification {0}", values:  val_1);
        }
        public void CancelNotification(int notificationId)
        {
            object[] val_1 = new object[1];
            val_1[0] = notificationId;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Cancel notification with id: {0}", values:  val_1);
        }
        public void DismissNotification(int notificationId)
        {
            object[] val_1 = new object[1];
            val_1[0] = notificationId;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Dismiss notification with id: {0}", values:  val_1);
        }
        public void CancelAllScheduledNotifications()
        {
            var val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Cancel all scheduled notifications", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void DismissAllNotifications()
        {
            var val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Dismiss all notifications", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public EditorGameNotificationPlatform()
        {
        
        }
    
    }

}
