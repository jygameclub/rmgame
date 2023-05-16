using UnityEngine;
public class OSNotification
{
    // Fields
    public bool isAppInFocus;
    public bool shown;
    public bool silentNotification;
    public int androidNotificationId;
    public OSNotification.DisplayType displayType;
    public OSNotificationPayload payload;
    
    // Methods
    public OSNotification()
    {
    
    }

}
