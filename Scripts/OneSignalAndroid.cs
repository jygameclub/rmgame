using UnityEngine;
public class OneSignalAndroid : OneSignalPlatform
{
    // Fields
    private static UnityEngine.AndroidJavaObject mOneSignal;
    
    // Methods
    public OneSignalAndroid(string gameObjectName, string googleProjectNumber, string appId, OneSignal.OSInFocusDisplayOption displayOption, OneSignal.LOG_LEVEL logLevel, OneSignal.LOG_LEVEL visualLevel, bool requiresUserConsent)
    {
        int val_5;
        var val_6;
        val_1 = new System.Object();
        object[] val_2 = new object[6];
        val_5 = val_2.Length;
        val_2[0] = gameObjectName;
        if(val_1 != null)
        {
                val_5 = val_2.Length;
        }
        
        val_2[1] = val_1;
        if(appId != null)
        {
                val_5 = val_2.Length;
        }
        
        val_2[2] = appId;
        val_2[3] = logLevel;
        val_2[4] = visualLevel;
        val_2[5] = requiresUserConsent;
        val_6 = null;
        val_6 = null;
        OneSignalAndroid.mOneSignal = new UnityEngine.AndroidJavaObject(className:  "com.onesignal.OneSignalUnityProxy", args:  val_2);
        SetInFocusDisplaying(display:  displayOption);
    }
    public void SetLogLevel(OneSignal.LOG_LEVEL logLevel, OneSignal.LOG_LEVEL visualLevel)
    {
        null = null;
        object[] val_1 = new object[2];
        val_1[0] = logLevel;
        val_1[1] = visualLevel;
        OneSignalAndroid.mOneSignal.Call(methodName:  "setLogLevel", args:  val_1);
    }
    public void SetLocationShared(bool shared)
    {
        var val_3 = null;
        object[] val_2 = new object[1];
        val_2[0] = shared;
        OneSignalAndroid.mOneSignal.Call(methodName:  "setLocationShared", args:  val_2);
    }
    public void SendTag(string tagName, string tagValue)
    {
        var val_2;
        int val_3;
        val_2 = null;
        val_2 = null;
        object[] val_1 = new object[2];
        val_3 = val_1.Length;
        val_1[0] = tagName;
        if(tagValue != null)
        {
                val_3 = val_1.Length;
        }
        
        val_1[1] = tagValue;
        OneSignalAndroid.mOneSignal.Call(methodName:  "sendTag", args:  val_1);
    }
    public void SendTags(System.Collections.Generic.IDictionary<string, string> tags)
    {
        null = null;
        object[] val_1 = new object[1];
        val_1[0] = Json.Serializer.Serialize(obj:  tags);
        OneSignalAndroid.mOneSignal.Call(methodName:  "sendTags", args:  val_1);
    }
    public void GetTags(string delegateId)
    {
        null = null;
        object[] val_1 = new object[1];
        val_1[0] = delegateId;
        OneSignalAndroid.mOneSignal.Call(methodName:  "getTags", args:  val_1);
    }
    public void DeleteTag(string key)
    {
        null = null;
        object[] val_1 = new object[1];
        val_1[0] = key;
        OneSignalAndroid.mOneSignal.Call(methodName:  "deleteTag", args:  val_1);
    }
    public void DeleteTags(System.Collections.Generic.IList<string> keys)
    {
        null = null;
        object[] val_1 = new object[1];
        val_1[0] = Json.Serializer.Serialize(obj:  keys);
        OneSignalAndroid.mOneSignal.Call(methodName:  "deleteTags", args:  val_1);
    }
    public void IdsAvailable(string delegateId)
    {
        null = null;
        object[] val_1 = new object[1];
        val_1[0] = delegateId;
        OneSignalAndroid.mOneSignal.Call(methodName:  "idsAvailable", args:  val_1);
    }
    public void RegisterForPushNotifications()
    {
    
    }
    public void PromptForPushNotificationsWithUserResponse()
    {
    
    }
    public void EnableVibrate(bool enable)
    {
        var val_3 = null;
        object[] val_2 = new object[1];
        val_2[0] = enable;
        OneSignalAndroid.mOneSignal.Call(methodName:  "enableVibrate", args:  val_2);
    }
    public void EnableSound(bool enable)
    {
        var val_3 = null;
        object[] val_2 = new object[1];
        val_2[0] = enable;
        OneSignalAndroid.mOneSignal.Call(methodName:  "enableSound", args:  val_2);
    }
    public void SetInFocusDisplaying(OneSignal.OSInFocusDisplayOption display)
    {
        null = null;
        object[] val_1 = new object[1];
        val_1[0] = display;
        OneSignalAndroid.mOneSignal.Call(methodName:  "setInFocusDisplaying", args:  val_1);
    }
    public void SetSubscription(bool enable)
    {
        var val_3 = null;
        object[] val_2 = new object[1];
        val_2[0] = enable;
        OneSignalAndroid.mOneSignal.Call(methodName:  "setSubscription", args:  val_2);
    }
    public void PostNotification(string delegateIdSuccess, string delegateIdFailure, System.Collections.Generic.Dictionary<string, object> data)
    {
        var val_3;
        int val_4;
        val_3 = null;
        val_3 = null;
        object[] val_1 = new object[3];
        val_4 = val_1.Length;
        val_1[0] = delegateIdSuccess;
        if(delegateIdFailure != null)
        {
                val_4 = val_1.Length;
        }
        
        val_1[1] = delegateIdFailure;
        val_1[2] = Json.Serializer.Serialize(obj:  data);
        OneSignalAndroid.mOneSignal.Call(methodName:  "postNotification", args:  val_1);
    }
    public void SyncHashedEmail(string email)
    {
        null = null;
        object[] val_1 = new object[1];
        val_1[0] = email;
        OneSignalAndroid.mOneSignal.Call(methodName:  "syncHashedEmail", args:  val_1);
    }
    public void PromptLocation()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        OneSignalAndroid.mOneSignal.Call(methodName:  "promptLocation", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
    }
    public void ClearOneSignalNotifications()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        OneSignalAndroid.mOneSignal.Call(methodName:  "clearOneSignalNotifications", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
    }
    public void AddPermissionObserver()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        OneSignalAndroid.mOneSignal.Call(methodName:  "addPermissionObserver", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
    }
    public void RemovePermissionObserver()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        OneSignalAndroid.mOneSignal.Call(methodName:  "removePermissionObserver", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
    }
    public void AddSubscriptionObserver()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        OneSignalAndroid.mOneSignal.Call(methodName:  "addSubscriptionObserver", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
    }
    public void RemoveSubscriptionObserver()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        OneSignalAndroid.mOneSignal.Call(methodName:  "removeSubscriptionObserver", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
    }
    public void AddEmailSubscriptionObserver()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        OneSignalAndroid.mOneSignal.Call(methodName:  "addEmailSubscriptionObserver", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
    }
    public void RemoveEmailSubscriptionObserver()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        OneSignalAndroid.mOneSignal.Call(methodName:  "removeEmailSubscriptionObserver", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
    }
    public void UserDidProvideConsent(bool consent)
    {
        var val_3 = null;
        object[] val_2 = new object[1];
        val_2[0] = consent;
        OneSignalAndroid.mOneSignal.Call(methodName:  "provideUserConsent", args:  val_2);
    }
    public bool UserProvidedConsent()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        return OneSignalAndroid.mOneSignal.Call<System.Boolean>(methodName:  "userProvidedPrivacyConsent", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
    }
    public void SetRequiresUserPrivacyConsent(bool required)
    {
        var val_3 = null;
        object[] val_2 = new object[1];
        val_2[0] = required;
        OneSignalAndroid.mOneSignal.Call(methodName:  "setRequiresUserPrivacyConsent", args:  val_2);
    }
    public void SetExternalUserId(string delegateId, string externalId)
    {
        var val_2;
        int val_3;
        val_2 = null;
        val_2 = null;
        object[] val_1 = new object[2];
        val_3 = val_1.Length;
        val_1[0] = delegateId;
        if(externalId != null)
        {
                val_3 = val_1.Length;
        }
        
        val_1[1] = externalId;
        OneSignalAndroid.mOneSignal.Call(methodName:  "setExternalUserId", args:  val_1);
    }
    public void RemoveExternalUserId(string delegateId)
    {
        null = null;
        object[] val_1 = new object[1];
        val_1[0] = delegateId;
        OneSignalAndroid.mOneSignal.Call(methodName:  "removeExternalUserId", args:  val_1);
    }
    public OSPermissionSubscriptionState GetPermissionSubscriptionState()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        return OneSignalPlatformHelper.ParsePermissionSubscriptionState(platform:  this, jsonStr:  OneSignalAndroid.mOneSignal.Call<System.String>(methodName:  "getPermissionSubscriptionState", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184));
    }
    public OSPermissionStateChanges ParseOSPermissionStateChanges(string jsonStat)
    {
        return OneSignalPlatformHelper.ParseOSPermissionStateChanges(platform:  this, stateChangesJSONString:  jsonStat);
    }
    public OSSubscriptionStateChanges ParseOSSubscriptionStateChanges(string jsonStat)
    {
        return OneSignalPlatformHelper.ParseOSSubscriptionStateChanges(platform:  this, stateChangesJSONString:  jsonStat);
    }
    public OSEmailSubscriptionStateChanges ParseOSEmailSubscriptionStateChanges(string jsonState)
    {
        return OneSignalPlatformHelper.ParseOSEmailSubscriptionStateChanges(platform:  this, stateChangesJSONString:  jsonState);
    }
    public OSPermissionState ParseOSPermissionState(object stateDict)
    {
        var val_6 = 0;
        .hasPrompted = true;
        .status = ((System.Convert.ToBoolean(value:  Item["enabled"])) != true) ? (1 + 1) : 1;
        return (OSPermissionState)new OSPermissionState();
    }
    public OSSubscriptionState ParseOSSubscriptionState(object stateDict)
    {
        var val_13;
        string val_14;
        string val_15;
        val_13 = 0;
        .subscribed = System.Convert.ToBoolean(value:  Item["subscribed"]);
        .userSubscriptionSetting = System.Convert.ToBoolean(value:  Item["userSubscriptionSetting"]);
        object val_9 = Item["userId"];
        if(val_9 != null)
        {
                var val_10 = (null == null) ? (val_9) : 0;
        }
        else
        {
                val_14 = 0;
        }
        
        .userId = val_14;
        object val_11 = Item["pushToken"];
        if(val_11 != null)
        {
                var val_12 = (null == null) ? (val_11) : 0;
        }
        else
        {
                val_15 = 0;
        }
        
        .pushToken = val_15;
        return (OSSubscriptionState)new OSSubscriptionState();
    }
    public OSEmailSubscriptionState ParseOSEmailSubscriptionState(object stateDict)
    {
        var val_10;
        string val_11;
        string val_12;
        val_10 = 0;
        .subscribed = System.Convert.ToBoolean(value:  Item["subscribed"]);
        object val_6 = Item["emailUserId"];
        if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_11 = 0;
        }
        
        .emailUserId = val_11;
        object val_8 = Item["emailAddress"];
        if(val_8 != null)
        {
                var val_9 = (null == null) ? (val_8) : 0;
        }
        else
        {
                val_12 = 0;
        }
        
        .emailAddress = val_12;
        return (OSEmailSubscriptionState)new OSEmailSubscriptionState();
    }
    public void SetEmail(string delegateIdSuccess, string delegateIdFailure, string email)
    {
        var val_2;
        int val_3;
        val_2 = null;
        val_2 = null;
        object[] val_1 = new object[4];
        val_3 = val_1.Length;
        val_1[0] = delegateIdSuccess;
        if(delegateIdFailure != null)
        {
                val_3 = val_1.Length;
        }
        
        val_1[1] = delegateIdFailure;
        if(email != null)
        {
                val_3 = val_1.Length;
        }
        
        val_1[2] = email;
        OneSignalAndroid.mOneSignal.Call(methodName:  "setEmail", args:  val_1);
    }
    public void SetEmail(string delegateIdSuccess, string delegateIdFailure, string email, string emailAuthCode)
    {
        var val_2;
        int val_3;
        val_2 = null;
        val_2 = null;
        object[] val_1 = new object[4];
        val_3 = val_1.Length;
        val_1[0] = delegateIdSuccess;
        if(delegateIdFailure != null)
        {
                val_3 = val_1.Length;
        }
        
        val_1[1] = delegateIdFailure;
        if(email != null)
        {
                val_3 = val_1.Length;
        }
        
        val_1[2] = email;
        if(emailAuthCode != null)
        {
                val_3 = val_1.Length;
        }
        
        val_1[3] = emailAuthCode;
        OneSignalAndroid.mOneSignal.Call(methodName:  "setEmail", args:  val_1);
    }
    public void LogoutEmail(string delegateIdSuccess, string delegateIdFailure)
    {
        var val_2;
        int val_3;
        val_2 = null;
        val_2 = null;
        object[] val_1 = new object[2];
        val_3 = val_1.Length;
        val_1[0] = delegateIdSuccess;
        if(delegateIdFailure != null)
        {
                val_3 = val_1.Length;
        }
        
        val_1[1] = delegateIdFailure;
        OneSignalAndroid.mOneSignal.Call(methodName:  "logoutEmail", args:  val_1);
    }
    public void AddTrigger(string key, object value)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        val_3 = 2;
        object[] val_1 = new object[2];
        val_1[0] = key;
        val_1[1] = value;
        OneSignalAndroid.mOneSignal.Call(methodName:  "addTrigger", args:  val_1);
    }
    public void AddTriggers(System.Collections.Generic.IDictionary<string, object> triggers)
    {
        null = null;
        object[] val_1 = new object[1];
        val_1[0] = Json.Serializer.Serialize(obj:  triggers);
        OneSignalAndroid.mOneSignal.Call(methodName:  "addTriggers", args:  val_1);
    }
    public void RemoveTriggerForKey(string key)
    {
        null = null;
        object[] val_1 = new object[1];
        val_1[0] = key;
        OneSignalAndroid.mOneSignal.Call(methodName:  "removeTriggerForKey", args:  val_1);
    }
    public void RemoveTriggersForKeys(System.Collections.Generic.IList<string> keys)
    {
        null = null;
        object[] val_1 = new object[1];
        val_1[0] = Json.Serializer.Serialize(obj:  keys);
        OneSignalAndroid.mOneSignal.Call(methodName:  "removeTriggersForKeys", args:  val_1);
    }
    public object GetTriggerValueForKey(string key)
    {
        object val_5;
        var val_6;
        val_5 = key;
        val_6 = null;
        val_6 = null;
        object[] val_1 = new object[1];
        val_1[0] = val_5;
        string val_2 = OneSignalAndroid.mOneSignal.Call<System.String>(methodName:  "getTriggerValueForKey", args:  val_1);
        if(val_2 == null)
        {
                return 0;
        }
        
        val_5 = Json.Parser.Parse(jsonString:  val_2);
        if((val_5.ContainsKey(key:  "value")) == false)
        {
                return 0;
        }
        
        return val_5.Item["value"];
    }
    public void PauseInAppMessages(bool pause)
    {
        var val_3 = null;
        object[] val_2 = new object[1];
        val_2[0] = pause;
        OneSignalAndroid.mOneSignal.Call(methodName:  "pauseInAppMessages", args:  val_2);
    }
    public void SendOutcome(string delegateId, string name)
    {
        var val_2;
        int val_3;
        val_2 = null;
        val_2 = null;
        object[] val_1 = new object[2];
        val_3 = val_1.Length;
        val_1[0] = delegateId;
        if(name != null)
        {
                val_3 = val_1.Length;
        }
        
        val_1[1] = name;
        OneSignalAndroid.mOneSignal.Call(methodName:  "sendOutcome", args:  val_1);
    }
    public void SendUniqueOutcome(string delegateId, string name)
    {
        var val_2;
        int val_3;
        val_2 = null;
        val_2 = null;
        object[] val_1 = new object[2];
        val_3 = val_1.Length;
        val_1[0] = delegateId;
        if(name != null)
        {
                val_3 = val_1.Length;
        }
        
        val_1[1] = name;
        OneSignalAndroid.mOneSignal.Call(methodName:  "sendUniqueOutcome", args:  val_1);
    }
    public void SendOutcomeWithValue(string delegateId, string name, float value)
    {
        var val_2;
        int val_3;
        val_2 = null;
        val_2 = null;
        object[] val_1 = new object[3];
        val_3 = val_1.Length;
        val_1[0] = delegateId;
        if(name != null)
        {
                val_3 = val_1.Length;
        }
        
        val_1[1] = name;
        val_1[2] = value;
        OneSignalAndroid.mOneSignal.Call(methodName:  "sendOutcomeWithValue", args:  val_1);
    }
    private static OneSignalAndroid()
    {
    
    }

}
