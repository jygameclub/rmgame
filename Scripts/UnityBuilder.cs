using UnityEngine;
public class OneSignal.UnityBuilder
{
    // Fields
    public string appID;
    public string googleProjectNumber;
    public System.Collections.Generic.Dictionary<string, bool> iOSSettings;
    public OneSignal.NotificationReceived notificationReceivedDelegate;
    public OneSignal.NotificationOpened notificationOpenedDelegate;
    public OneSignal.InAppMessageClicked inAppMessageClickHandlerDelegate;
    
    // Methods
    public OneSignal.UnityBuilder HandleNotificationReceived(OneSignal.NotificationReceived inNotificationReceivedDelegate)
    {
        this.notificationReceivedDelegate = inNotificationReceivedDelegate;
        return (UnityBuilder)this;
    }
    public OneSignal.UnityBuilder HandleNotificationOpened(OneSignal.NotificationOpened inNotificationOpenedDelegate)
    {
        this.notificationOpenedDelegate = inNotificationOpenedDelegate;
        return (UnityBuilder)this;
    }
    public OneSignal.UnityBuilder HandleInAppMessageClicked(OneSignal.InAppMessageClicked inInAppMessageClickedDelegate)
    {
        this.inAppMessageClickHandlerDelegate = inInAppMessageClickedDelegate;
        return (UnityBuilder)this;
    }
    public OneSignal.UnityBuilder InFocusDisplaying(OneSignal.OSInFocusDisplayOption display)
    {
        OneSignal.inFocusDisplayType = display;
        return (UnityBuilder)this;
    }
    public OneSignal.UnityBuilder Settings(System.Collections.Generic.Dictionary<string, bool> settings)
    {
        return (UnityBuilder)this;
    }
    public void EndInit()
    {
        OneSignal.Init();
    }
    public OneSignal.UnityBuilder SetRequiresUserPrivacyConsent(bool required)
    {
        null = null;
        OneSignal.requiresUserConsent = true;
        return (UnityBuilder)this;
    }
    public OneSignal.UnityBuilder()
    {
    
    }

}
