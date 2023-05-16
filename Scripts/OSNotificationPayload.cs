using UnityEngine;
public class OSNotificationPayload
{
    // Fields
    public string notificationID;
    public string sound;
    public string title;
    public string body;
    public string subtitle;
    public string launchURL;
    public System.Collections.Generic.Dictionary<string, object> additionalData;
    public System.Collections.Generic.Dictionary<string, object> actionButtons;
    public bool contentAvailable;
    public int badge;
    public string smallIcon;
    public string largeIcon;
    public string bigPicture;
    public string smallIconAccentColor;
    public string ledColor;
    public int lockScreenVisibility;
    public string groupKey;
    public string groupMessage;
    public string fromProjectNumber;
    
    // Methods
    public OSNotificationPayload()
    {
        this.lockScreenVisibility = 1;
    }

}
