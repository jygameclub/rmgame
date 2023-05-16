using UnityEngine;
public interface OneSignalPlatform
{
    // Methods
    public abstract void SetLogLevel(OneSignal.LOG_LEVEL logLevel, OneSignal.LOG_LEVEL visualLevel); // 0
    public abstract void RegisterForPushNotifications(); // 0
    public abstract void PromptForPushNotificationsWithUserResponse(); // 0
    public abstract void SendTag(string tagName, string tagValue); // 0
    public abstract void SendTags(System.Collections.Generic.IDictionary<string, string> tags); // 0
    public abstract void GetTags(string delegateId); // 0
    public abstract void DeleteTag(string key); // 0
    public abstract void DeleteTags(System.Collections.Generic.IList<string> keys); // 0
    public abstract void IdsAvailable(string delegateId); // 0
    public abstract void SetSubscription(bool enable); // 0
    public abstract void PostNotification(string delegateIdSuccess, string delegateIdFailure, System.Collections.Generic.Dictionary<string, object> data); // 0
    public abstract void SyncHashedEmail(string email); // 0
    public abstract void PromptLocation(); // 0
    public abstract void SetLocationShared(bool shared); // 0
    public abstract void SetEmail(string delegateIdSuccess, string delegateIdFailure, string email); // 0
    public abstract void SetEmail(string delegateIdSuccess, string delegateIdFailure, string email, string emailAuthToken); // 0
    public abstract void LogoutEmail(string delegateIdSuccess, string delegateIdFailure); // 0
    public abstract void SetInFocusDisplaying(OneSignal.OSInFocusDisplayOption display); // 0
    public abstract void UserDidProvideConsent(bool consent); // 0
    public abstract bool UserProvidedConsent(); // 0
    public abstract void SetRequiresUserPrivacyConsent(bool required); // 0
    public abstract void SetExternalUserId(string delegateId, string externalId); // 0
    public abstract void RemoveExternalUserId(string delegateId); // 0
    public abstract void AddPermissionObserver(); // 0
    public abstract void RemovePermissionObserver(); // 0
    public abstract void AddSubscriptionObserver(); // 0
    public abstract void RemoveSubscriptionObserver(); // 0
    public abstract void AddEmailSubscriptionObserver(); // 0
    public abstract void RemoveEmailSubscriptionObserver(); // 0
    public abstract OSPermissionSubscriptionState GetPermissionSubscriptionState(); // 0
    public abstract void AddTrigger(string key, object value); // 0
    public abstract void AddTriggers(System.Collections.Generic.IDictionary<string, object> triggers); // 0
    public abstract void RemoveTriggerForKey(string key); // 0
    public abstract void RemoveTriggersForKeys(System.Collections.Generic.IList<string> keys); // 0
    public abstract object GetTriggerValueForKey(string key); // 0
    public abstract void PauseInAppMessages(bool pause); // 0
    public abstract void SendOutcome(string delegateId, string name); // 0
    public abstract void SendUniqueOutcome(string delegateId, string name); // 0
    public abstract void SendOutcomeWithValue(string delegateId, string name, float value); // 0
    public abstract OSPermissionState ParseOSPermissionState(object stateDict); // 0
    public abstract OSSubscriptionState ParseOSSubscriptionState(object stateDict); // 0
    public abstract OSEmailSubscriptionState ParseOSEmailSubscriptionState(object stateDict); // 0
    public abstract OSPermissionStateChanges ParseOSPermissionStateChanges(string stateChangesJSONString); // 0
    public abstract OSSubscriptionStateChanges ParseOSSubscriptionStateChanges(string stateChangesJSONString); // 0
    public abstract OSEmailSubscriptionStateChanges ParseOSEmailSubscriptionStateChanges(string stateChangesJSONString); // 0

}
