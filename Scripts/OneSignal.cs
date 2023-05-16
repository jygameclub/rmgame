using UnityEngine;
public class OneSignal : MonoBehaviour
{
    // Fields
    private static System.Collections.Generic.Dictionary<string, System.Delegate> delegates;
    private static OneSignal.PromptForPushNotificationsUserResponse notificationUserResponseDelegate;
    private static OneSignal.PermissionObservable internalPermissionObserver;
    private static bool addedPermissionObserver;
    private static OneSignal.SubscriptionObservable internalSubscriptionObserver;
    private static bool addedSubscriptionObserver;
    private static OneSignal.EmailSubscriptionObservable internalEmailSubscriptionObserver;
    private static bool addedEmailSubscriptionObserver;
    public const string kOSSettingsAutoPrompt = "kOSSettingsAutoPrompt";
    public const string kOSSettingsInAppLaunchURL = "kOSSettingsInAppLaunchURL";
    internal static OneSignal.UnityBuilder builder;
    private static OneSignalPlatform oneSignalPlatform;
    private const string gameObjectName = "OneSignalRuntimeObject_KEEP";
    private static OneSignal.LOG_LEVEL logLevel;
    private static OneSignal.LOG_LEVEL visualLogLevel;
    internal static bool requiresUserConsent;
    private static OneSignal.OSInFocusDisplayOption _inFocusDisplayType;
    
    // Properties
    public static OneSignal.OSInFocusDisplayOption inFocusDisplayType { get; set; }
    
    // Methods
    public static void add_permissionObserver(OneSignal.PermissionObservable value)
    {
        var val_2 = null;
        if(OneSignal.oneSignalPlatform == null)
        {
                return;
        }
        
        System.Delegate val_1 = System.Delegate.Combine(a:  OneSignal.internalPermissionObserver, b:  value);
        if(val_1 != null)
        {
                if(null != null)
        {
            goto label_7;
        }
        
        }
        
        OneSignal.internalPermissionObserver = val_1;
        OneSignal.addPermissionObserver();
        return;
        label_7:
    }
    public static void remove_permissionObserver(OneSignal.PermissionObservable value)
    {
        var val_3;
        System.Delegate val_5;
        var val_7;
        val_3 = null;
        val_3 = null;
        if(OneSignal.oneSignalPlatform == null)
        {
                return;
        }
        
        val_5 = value;
        System.Delegate val_1 = System.Delegate.Remove(source:  OneSignal.internalPermissionObserver, value:  val_5);
        if(val_1 == null)
        {
            goto label_6;
        }
        
        val_5 = null;
        if(null != val_5)
        {
            goto label_7;
        }
        
        label_6:
        OneSignal.internalPermissionObserver = val_1;
        if(OneSignal.addedPermissionObserver == false)
        {
                return;
        }
        
        if((mem[val_1 + 24]) != 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        OneSignal.addedPermissionObserver = false;
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 24;
            OneSignalPlatform val_2 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.RemovePermissionObserver();
        return;
        label_7:
    }
    private static void addPermissionObserver()
    {
        var val_3;
        PermissionObservable val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        if(OneSignal.addedPermissionObserver != false)
        {
                return;
        }
        
        val_3 = null;
        val_5 = OneSignal.internalPermissionObserver;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = OneSignal.internalPermissionObserver;
        System.Delegate[] val_1 = val_5.GetInvocationList();
        if(val_1.Length == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        OneSignal.addedPermissionObserver = true;
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 23;
            OneSignalPlatform val_2 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.AddPermissionObserver();
    }
    public static void add_subscriptionObserver(OneSignal.SubscriptionObservable value)
    {
        var val_2 = null;
        if(OneSignal.oneSignalPlatform == null)
        {
                return;
        }
        
        System.Delegate val_1 = System.Delegate.Combine(a:  OneSignal.internalSubscriptionObserver, b:  value);
        if(val_1 != null)
        {
                if(null != null)
        {
            goto label_7;
        }
        
        }
        
        OneSignal.internalSubscriptionObserver = val_1;
        OneSignal.addSubscriptionObserver();
        return;
        label_7:
    }
    public static void remove_subscriptionObserver(OneSignal.SubscriptionObservable value)
    {
        var val_3;
        System.Delegate val_5;
        var val_7;
        val_3 = null;
        val_3 = null;
        if(OneSignal.oneSignalPlatform == null)
        {
                return;
        }
        
        val_5 = value;
        System.Delegate val_1 = System.Delegate.Remove(source:  OneSignal.internalSubscriptionObserver, value:  val_5);
        if(val_1 == null)
        {
            goto label_6;
        }
        
        val_5 = null;
        if(null != val_5)
        {
            goto label_7;
        }
        
        label_6:
        OneSignal.internalSubscriptionObserver = val_1;
        if(OneSignal.addedSubscriptionObserver == false)
        {
                return;
        }
        
        if((mem[val_1 + 24]) != 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 26;
            OneSignalPlatform val_2 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.RemoveSubscriptionObserver();
        return;
        label_7:
    }
    private static void addSubscriptionObserver()
    {
        var val_3;
        SubscriptionObservable val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        if(OneSignal.addedSubscriptionObserver != false)
        {
                return;
        }
        
        val_3 = null;
        val_5 = OneSignal.internalSubscriptionObserver;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = OneSignal.internalSubscriptionObserver;
        System.Delegate[] val_1 = val_5.GetInvocationList();
        if(val_1.Length == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        OneSignal.addedSubscriptionObserver = true;
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 25;
            OneSignalPlatform val_2 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.AddSubscriptionObserver();
    }
    public static void add_emailSubscriptionObserver(OneSignal.EmailSubscriptionObservable value)
    {
        var val_2 = null;
        if(OneSignal.oneSignalPlatform == null)
        {
                return;
        }
        
        System.Delegate val_1 = System.Delegate.Combine(a:  OneSignal.internalEmailSubscriptionObserver, b:  value);
        if(val_1 != null)
        {
                if(null != null)
        {
            goto label_7;
        }
        
        }
        
        OneSignal.internalEmailSubscriptionObserver = val_1;
        OneSignal.addEmailSubscriptionObserver();
        return;
        label_7:
    }
    public static void remove_emailSubscriptionObserver(OneSignal.EmailSubscriptionObservable value)
    {
        var val_3;
        System.Delegate val_5;
        var val_7;
        val_3 = null;
        val_3 = null;
        if(OneSignal.oneSignalPlatform == null)
        {
                return;
        }
        
        val_5 = value;
        System.Delegate val_1 = System.Delegate.Remove(source:  OneSignal.internalEmailSubscriptionObserver, value:  val_5);
        if(val_1 == null)
        {
            goto label_6;
        }
        
        val_5 = null;
        if(null != val_5)
        {
            goto label_7;
        }
        
        label_6:
        OneSignal.internalEmailSubscriptionObserver = val_1;
        if(OneSignal.addedEmailSubscriptionObserver == false)
        {
                return;
        }
        
        if((mem[val_1 + 24]) != 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 28;
            OneSignalPlatform val_2 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.RemoveEmailSubscriptionObserver();
        return;
        label_7:
    }
    private static void addEmailSubscriptionObserver()
    {
        var val_3;
        EmailSubscriptionObservable val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        if(OneSignal.addedEmailSubscriptionObserver != false)
        {
                return;
        }
        
        val_3 = null;
        val_5 = OneSignal.internalEmailSubscriptionObserver;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = OneSignal.internalEmailSubscriptionObserver;
        System.Delegate[] val_1 = val_5.GetInvocationList();
        if(val_1.Length == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        OneSignal.addedEmailSubscriptionObserver = true;
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 27;
            OneSignalPlatform val_2 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.AddEmailSubscriptionObserver();
    }
    public static OneSignal.UnityBuilder StartInit(string appID, string googleProjectNumber)
    {
        OneSignal.UnityBuilder val_2;
        var val_3 = null;
        if(OneSignal.builder == null)
        {
                OneSignal.UnityBuilder val_1 = null;
            val_2 = val_1;
            val_1 = new OneSignal.UnityBuilder();
            val_3 = null;
            val_3 = null;
            OneSignal.builder = val_2;
        }
        
        val_3 = null;
        mem[1152921518854973888] = appID;
        mem[1152921518854973896] = googleProjectNumber;
        return (UnityBuilder)OneSignal.builder;
    }
    private static void Init()
    {
        System.Collections.Generic.Dictionary<TKey, TValue> val_2;
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(OneSignal.gameObjectName == null)
        {
                System.Collections.Generic.Dictionary<System.String, System.Delegate> val_1 = null;
            val_2 = val_1;
            val_1 = new System.Collections.Generic.Dictionary<System.String, System.Delegate>();
            val_4 = null;
            val_4 = null;
            OneSignal.gameObjectName = val_2;
            val_3 = null;
        }
        
        OneSignal.initOneSignalPlatform();
    }
    private static void initOneSignalPlatform()
    {
        if(OneSignal.oneSignalPlatform != null)
        {
                return;
        }
        
        null = null;
        if(OneSignal.builder == null)
        {
                return;
        }
        
        OneSignal.initAndroid();
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "OneSignalRuntimeObject_KEEP");
        OneSignal val_2 = val_1.AddComponent<OneSignal>();
        UnityEngine.Object.DontDestroyOnLoad(target:  val_1);
        OneSignal.addPermissionObserver();
        OneSignal.addSubscriptionObserver();
    }
    private static void initAndroid()
    {
        null = null;
        OneSignal.oneSignalPlatform = new OneSignalAndroid(gameObjectName:  "OneSignalRuntimeObject_KEEP", googleProjectNumber:  OneSignal.builder.googleProjectNumber, appId:  OneSignal.builder.appID, displayOption:  OneSignal._inFocusDisplayType, logLevel:  OneSignal.logLevel, visualLevel:  OneSignal.visualLogLevel, requiresUserConsent:  OneSignal.requiresUserConsent);
    }
    private static void initUnityEditor()
    {
        UnityEngine.MonoBehaviour.print(message:  "Please run OneSignal on a device to see push notifications.");
    }
    public static OneSignal.OSInFocusDisplayOption get_inFocusDisplayType()
    {
        null = null;
        return (OSInFocusDisplayOption)OneSignal._inFocusDisplayType;
    }
    public static void set_inFocusDisplayType(OneSignal.OSInFocusDisplayOption value)
    {
        var val_1;
        OneSignalPlatform val_3;
        val_1 = null;
        val_1 = null;
        OneSignal._inFocusDisplayType = value;
        val_3 = OneSignal.oneSignalPlatform;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = OneSignal.oneSignalPlatform;
        var val_1 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_1 = val_1 + 1;
        }
        else
        {
                var val_2 = mem[1152921505019609096];
            val_2 = val_2 + 17;
            val_2 = oneSignalPlatform + val_2;
        }
        
        val_3.SetInFocusDisplaying(display:  OneSignal._inFocusDisplayType);
    }
    public static void SetLogLevel(OneSignal.LOG_LEVEL inLogLevel, OneSignal.LOG_LEVEL inVisualLevel)
    {
        null = null;
        OneSignal.logLevel = inLogLevel;
        OneSignal.visualLogLevel = inVisualLevel;
    }
    public static void SetLocationShared(bool shared)
    {
        var val_3;
        UnityEngine.Debug.Log(message:  "Called OneSignal.cs SetLocationShared");
        val_3 = null;
        val_3 = null;
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 13;
            OneSignalPlatform val_1 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.SetLocationShared(shared:  shared);
    }
    public static void SendTag(string tagName, string tagValue)
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 3;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.SendTag(tagName:  tagName, tagValue:  tagValue);
    }
    public static void SendTags(System.Collections.Generic.Dictionary<string, string> tags)
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 4;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.SendTags(tags:  tags);
    }
    public static void GetTags()
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 5;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.GetTags(delegateId:  0);
    }
    public static void GetTags(OneSignal.TagsReceived inTagsReceivedDelegate)
    {
        var val_3;
        System.Delegate val_4;
        string val_1 = OneSignalUnityUtils.GetNewGuid();
        val_3 = null;
        val_3 = null;
        val_4 = inTagsReceivedDelegate;
        OneSignal.gameObjectName.Add(key:  val_1, value:  val_4);
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
            val_4 = 5;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 5;
            OneSignalPlatform val_2 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.GetTags(delegateId:  val_1);
    }
    public static void DeleteTag(string key)
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 6;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.DeleteTag(key:  key);
    }
    public static void DeleteTags(System.Collections.Generic.IList<string> keys)
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 7;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.DeleteTags(keys:  keys);
    }
    public static void RegisterForPushNotifications()
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 1;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.RegisterForPushNotifications();
    }
    public static void PromptForPushNotificationsWithUserResponse(OneSignal.PromptForPushNotificationsUserResponse inDelegate)
    {
        var val_2 = null;
        OneSignal.notificationUserResponseDelegate = inDelegate;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 2;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.PromptForPushNotificationsWithUserResponse();
    }
    public static void IdsAvailable()
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 8;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.IdsAvailable(delegateId:  0);
    }
    public static void IdsAvailable(OneSignal.IdsAvailableCallback inIdsAvailableDelegate)
    {
        var val_3;
        System.Delegate val_4;
        string val_1 = OneSignalUnityUtils.GetNewGuid();
        val_3 = null;
        val_3 = null;
        val_4 = inIdsAvailableDelegate;
        OneSignal.gameObjectName.Add(key:  val_1, value:  val_4);
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
            val_4 = 8;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 8;
            OneSignalPlatform val_2 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.IdsAvailable(delegateId:  val_1);
    }
    public static void EnableVibrate(bool enable)
    {
        null = null;
        OneSignal.oneSignalPlatform.EnableVibrate(enable:  enable);
    }
    public static void EnableSound(bool enable)
    {
        null = null;
        OneSignal.oneSignalPlatform.EnableSound(enable:  enable);
    }
    public static void ClearOneSignalNotifications()
    {
        null = null;
        OneSignal.oneSignalPlatform.ClearOneSignalNotifications();
    }
    public static void SetSubscription(bool enable)
    {
        var val_3 = null;
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 9;
            OneSignalPlatform val_1 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.SetSubscription(enable:  enable);
    }
    public static void SetEmail(string email)
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 14;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.SetEmail(delegateIdSuccess:  0, delegateIdFailure:  0, email:  email);
    }
    public static void SetEmail(string email, OneSignal.OnSetEmailSuccess successDelegate, OneSignal.OnSetEmailFailure failureDelegate)
    {
        var val_4;
        string val_1 = OneSignalUnityUtils.GetNewGuid();
        string val_2 = OneSignalUnityUtils.GetNewGuid();
        val_4 = null;
        val_4 = null;
        OneSignal.gameObjectName.Add(key:  val_1, value:  successDelegate);
        OneSignal.gameObjectName.Add(key:  val_2, value:  failureDelegate);
        var val_4 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_4 = val_4 + 1;
        }
        else
        {
                var val_5 = mem[1152921505019609096];
            val_5 = val_5 + 14;
            OneSignalPlatform val_3 = oneSignalPlatform + val_5;
        }
        
        OneSignal.oneSignalPlatform.SetEmail(delegateIdSuccess:  val_1, delegateIdFailure:  val_2, email:  email);
    }
    public static void SetEmail(string email, string emailAuthToken)
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 15;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.SetEmail(delegateIdSuccess:  0, delegateIdFailure:  0, email:  email, emailAuthToken:  emailAuthToken);
    }
    public static void SetEmail(string email, string emailAuthToken, OneSignal.OnSetEmailSuccess successDelegate, OneSignal.OnSetEmailFailure failureDelegate)
    {
        var val_4;
        string val_1 = OneSignalUnityUtils.GetNewGuid();
        string val_2 = OneSignalUnityUtils.GetNewGuid();
        val_4 = null;
        val_4 = null;
        OneSignal.gameObjectName.Add(key:  val_1, value:  successDelegate);
        OneSignal.gameObjectName.Add(key:  val_2, value:  failureDelegate);
        var val_4 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_4 = val_4 + 1;
        }
        else
        {
                var val_5 = mem[1152921505019609096];
            val_5 = val_5 + 15;
            OneSignalPlatform val_3 = oneSignalPlatform + val_5;
        }
        
        OneSignal.oneSignalPlatform.SetEmail(delegateIdSuccess:  val_1, delegateIdFailure:  val_2, email:  email, emailAuthToken:  emailAuthToken);
    }
    public static void LogoutEmail()
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 16;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.LogoutEmail(delegateIdSuccess:  0, delegateIdFailure:  0);
    }
    public static void LogoutEmail(OneSignal.OnLogoutEmailSuccess successDelegate, OneSignal.OnLogoutEmailFailure failureDelegate)
    {
        var val_4;
        string val_1 = OneSignalUnityUtils.GetNewGuid();
        string val_2 = OneSignalUnityUtils.GetNewGuid();
        val_4 = null;
        val_4 = null;
        OneSignal.gameObjectName.Add(key:  val_1, value:  successDelegate);
        OneSignal.gameObjectName.Add(key:  val_2, value:  failureDelegate);
        var val_4 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_4 = val_4 + 1;
        }
        else
        {
                var val_5 = mem[1152921505019609096];
            val_5 = val_5 + 16;
            OneSignalPlatform val_3 = oneSignalPlatform + val_5;
        }
        
        OneSignal.oneSignalPlatform.LogoutEmail(delegateIdSuccess:  val_1, delegateIdFailure:  val_2);
    }
    public static void PostNotification(System.Collections.Generic.Dictionary<string, object> data)
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 10;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.PostNotification(delegateIdSuccess:  0, delegateIdFailure:  0, data:  data);
    }
    public static void PostNotification(System.Collections.Generic.Dictionary<string, object> data, OneSignal.OnPostNotificationSuccess inOnPostNotificationSuccess, OneSignal.OnPostNotificationFailure inOnPostNotificationFailure)
    {
        var val_4;
        string val_1 = OneSignalUnityUtils.GetNewGuid();
        string val_2 = OneSignalUnityUtils.GetNewGuid();
        val_4 = null;
        val_4 = null;
        OneSignal.gameObjectName.Add(key:  val_1, value:  inOnPostNotificationSuccess);
        OneSignal.gameObjectName.Add(key:  val_2, value:  inOnPostNotificationFailure);
        var val_4 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_4 = val_4 + 1;
        }
        else
        {
                var val_5 = mem[1152921505019609096];
            val_5 = val_5 + 10;
            OneSignalPlatform val_3 = oneSignalPlatform + val_5;
        }
        
        OneSignal.oneSignalPlatform.PostNotification(delegateIdSuccess:  val_1, delegateIdFailure:  val_2, data:  data);
    }
    public static void SyncHashedEmail(string email)
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 11;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.SyncHashedEmail(email:  email);
    }
    public static void PromptLocation()
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 12;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.PromptLocation();
    }
    public static OSPermissionSubscriptionState GetPermissionSubscriptionState()
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
            return OneSignal.oneSignalPlatform.GetPermissionSubscriptionState();
        }
        
        var val_3 = mem[1152921505019609096];
        val_3 = val_3 + 29;
        OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        return OneSignal.oneSignalPlatform.GetPermissionSubscriptionState();
    }
    public static void UserDidProvideConsent(bool consent)
    {
        var val_3 = null;
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 18;
            OneSignalPlatform val_1 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.UserDidProvideConsent(consent:  consent);
    }
    public static bool UserProvidedConsent()
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
            return OneSignal.oneSignalPlatform.UserProvidedConsent();
        }
        
        var val_3 = mem[1152921505019609096];
        val_3 = val_3 + 19;
        OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        return OneSignal.oneSignalPlatform.UserProvidedConsent();
    }
    public static void SetRequiresUserPrivacyConsent(bool required)
    {
        null = null;
        OneSignal.requiresUserConsent = required;
    }
    public static void SetExternalUserId(string externalId)
    {
        var val_3 = null;
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 21;
            OneSignalPlatform val_2 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.SetExternalUserId(delegateId:  OneSignalUnityUtils.GetNewGuid(), externalId:  externalId);
    }
    public static void SetExternalUserId(string externalId, OneSignal.OnExternalUserIdUpdateCompletion completion)
    {
        var val_3;
        string val_1 = OneSignalUnityUtils.GetNewGuid();
        val_3 = null;
        val_3 = null;
        OneSignal.gameObjectName.Add(key:  val_1, value:  completion);
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 21;
            OneSignalPlatform val_2 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.SetExternalUserId(delegateId:  val_1, externalId:  externalId);
    }
    public static void RemoveExternalUserId()
    {
        var val_3 = null;
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 22;
            OneSignalPlatform val_2 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.RemoveExternalUserId(delegateId:  OneSignalUnityUtils.GetNewGuid());
    }
    public static void RemoveExternalUserId(OneSignal.OnExternalUserIdUpdateCompletion completion)
    {
        var val_3;
        System.Delegate val_4;
        string val_1 = OneSignalUnityUtils.GetNewGuid();
        val_3 = null;
        val_3 = null;
        val_4 = completion;
        OneSignal.gameObjectName.Add(key:  val_1, value:  val_4);
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
            val_4 = 22;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 22;
            OneSignalPlatform val_2 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.RemoveExternalUserId(delegateId:  val_1);
    }
    public static void AddTrigger(string key, object value)
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 30;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.AddTrigger(key:  key, value:  value);
    }
    public static void AddTriggers(System.Collections.Generic.Dictionary<string, object> triggers)
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 31;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.AddTriggers(triggers:  triggers);
    }
    public static void RemoveTriggerForKey(string key)
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 32;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.RemoveTriggerForKey(key:  key);
    }
    public static void RemoveTriggersForKeys(System.Collections.Generic.IList<string> keys)
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 33;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.RemoveTriggersForKeys(keys:  keys);
    }
    public static object GetTriggerValueForKey(string key)
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
            return OneSignal.oneSignalPlatform.GetTriggerValueForKey(key:  key);
        }
        
        var val_3 = mem[1152921505019609096];
        val_3 = val_3 + 34;
        OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        return OneSignal.oneSignalPlatform.GetTriggerValueForKey(key:  key);
    }
    public static void PauseInAppMessages(bool pause)
    {
        var val_3 = null;
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 35;
            OneSignalPlatform val_1 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.PauseInAppMessages(pause:  pause);
    }
    public static void SendOutcome(string name)
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 36;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.SendOutcome(delegateId:  0, name:  name);
    }
    public static void SendOutcome(string name, OneSignal.OnSendOutcomeSuccess onSendOutcomeSuccess)
    {
        var val_3;
        string val_1 = OneSignalUnityUtils.GetNewGuid();
        val_3 = null;
        val_3 = null;
        OneSignal.gameObjectName.Add(key:  val_1, value:  onSendOutcomeSuccess);
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 36;
            OneSignalPlatform val_2 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.SendOutcome(delegateId:  val_1, name:  name);
    }
    public static void SendUniqueOutcome(string name)
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 37;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.SendUniqueOutcome(delegateId:  0, name:  name);
    }
    public static void SendUniqueOutcome(string name, OneSignal.OnSendOutcomeSuccess onSendOutcomeSuccess)
    {
        var val_3;
        string val_1 = OneSignalUnityUtils.GetNewGuid();
        val_3 = null;
        val_3 = null;
        OneSignal.gameObjectName.Add(key:  val_1, value:  onSendOutcomeSuccess);
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 37;
            OneSignalPlatform val_2 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.SendUniqueOutcome(delegateId:  val_1, name:  name);
    }
    public static void SendOutcomeWithValue(string name, float value)
    {
        var val_2 = null;
        var val_2 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                var val_3 = mem[1152921505019609096];
            val_3 = val_3 + 38;
            OneSignalPlatform val_1 = oneSignalPlatform + val_3;
        }
        
        OneSignal.oneSignalPlatform.SendOutcomeWithValue(delegateId:  0, name:  name, value:  value);
    }
    public static void SendOutcomeWithValue(string name, float value, OneSignal.OnSendOutcomeSuccess onSendOutcomeSuccess)
    {
        var val_3;
        string val_1 = OneSignalUnityUtils.GetNewGuid();
        val_3 = null;
        val_3 = null;
        OneSignal.gameObjectName.Add(key:  val_1, value:  onSendOutcomeSuccess);
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 38;
            OneSignalPlatform val_2 = oneSignalPlatform + val_4;
        }
        
        OneSignal.oneSignalPlatform.SendOutcomeWithValue(delegateId:  val_1, name:  name, value:  value);
    }
    private OSNotification DictionaryToNotification(System.Collections.Generic.Dictionary<string, object> jsonObject)
    {
        string val_78;
        string val_79;
        string val_80;
        string val_81;
        string val_82;
        string val_83;
        var val_84;
        var val_85;
        var val_86;
        var val_87;
        var val_88;
        var val_89;
        string val_90;
        string val_91;
        string val_92;
        string val_93;
        string val_94;
        string val_95;
        string val_96;
        string val_97;
        OSNotificationPayload val_2 = null;
        .lockScreenVisibility = 1;
        val_2 = new OSNotificationPayload();
        object val_3 = jsonObject.Item["payload"];
        if((val_3.ContainsKey(key:  "notificationID")) != false)
        {
                object val_5 = val_3.Item["notificationID"];
            if(val_5 != null)
        {
                var val_6 = (null == null) ? (val_5) : 0;
        }
        else
        {
                val_78 = 0;
        }
        
            .notificationID = val_78;
        }
        
        if((val_3.ContainsKey(key:  "sound")) != false)
        {
                object val_8 = val_3.Item["sound"];
            if(val_8 != null)
        {
                var val_9 = (null == null) ? (val_8) : 0;
        }
        else
        {
                val_79 = 0;
        }
        
            .sound = val_79;
        }
        
        if((val_3.ContainsKey(key:  "title")) != false)
        {
                object val_11 = val_3.Item["title"];
            if(val_11 != null)
        {
                var val_12 = (null == null) ? (val_11) : 0;
        }
        else
        {
                val_80 = 0;
        }
        
            .title = val_80;
        }
        
        if((val_3.ContainsKey(key:  "body")) != false)
        {
                object val_14 = val_3.Item["body"];
            if(val_14 != null)
        {
                var val_15 = (null == 1152921504621649920) ? (val_14) : 0;
        }
        else
        {
                val_81 = 0;
        }
        
            .body = val_81;
        }
        
        if((val_3.ContainsKey(key:  "subtitle")) != false)
        {
                object val_17 = val_3.Item["subtitle"];
            if(val_17 != null)
        {
                var val_18 = (null == null) ? (val_17) : 0;
        }
        else
        {
                val_82 = 0;
        }
        
            .subtitle = val_82;
        }
        
        if((val_3.ContainsKey(key:  "launchURL")) != false)
        {
                object val_20 = val_3.Item["launchURL"];
            if(val_20 != null)
        {
                var val_21 = (null == null) ? (val_20) : 0;
        }
        else
        {
                val_83 = 0;
        }
        
            .launchURL = val_83;
        }
        
        if((val_3.ContainsKey(key:  "additionalData")) == false)
        {
            goto label_29;
        }
        
        object val_23 = val_3.Item["additionalData"];
        if(val_23 != null)
        {
                var val_24 = (null == null) ? (val_23) : 0;
        }
        else
        {
                val_84 = 0;
        }
        
        object val_25 = val_3.Item["additionalData"];
        if((val_84 == 0) || (val_25 == null))
        {
            goto label_33;
        }
        
        if(null == null)
        {
            goto label_34;
        }
        
        val_85 = 0;
        label_33:
        label_109:
        val_86 = 0;
        .additionalData = ;
        label_29:
        if((val_3.ContainsKey(key:  "actionButtons")) == false)
        {
            goto label_39;
        }
        
        object val_28 = val_3.Item["actionButtons"];
        if(val_28 != null)
        {
                var val_29 = (null == null) ? (val_28) : 0;
        }
        else
        {
                val_87 = 0;
        }
        
        object val_30 = val_3.Item["actionButtons"];
        if((val_87 == 0) || (val_30 == null))
        {
            goto label_43;
        }
        
        if(null == null)
        {
            goto label_44;
        }
        
        val_88 = 0;
        label_43:
        label_111:
        val_89 = 0;
        .actionButtons = ;
        label_39:
        if((val_3.ContainsKey(key:  "contentAvailable")) != false)
        {
                val_3.Item["contentAvailable"].System.IDisposable.Dispose();
            .contentAvailable = null;
        }
        
        if((val_3.ContainsKey(key:  "badge")) != false)
        {
                .badge = System.Convert.ToInt32(value:  val_3.Item["badge"]);
        }
        
        if((val_3.ContainsKey(key:  "smallIcon")) != false)
        {
                object val_38 = val_3.Item["smallIcon"];
            if(val_38 != null)
        {
                var val_39 = (null == null) ? (val_38) : 0;
        }
        else
        {
                val_90 = 0;
        }
        
            .smallIcon = val_90;
        }
        
        if((val_3.ContainsKey(key:  "largeIcon")) != false)
        {
                object val_41 = val_3.Item["largeIcon"];
            if(val_41 != null)
        {
                var val_42 = (null == null) ? (val_41) : 0;
        }
        else
        {
                val_91 = 0;
        }
        
            .largeIcon = val_91;
        }
        
        if((val_3.ContainsKey(key:  "bigPicture")) != false)
        {
                object val_44 = val_3.Item["bigPicture"];
            if(val_44 != null)
        {
                var val_45 = (null == null) ? (val_44) : 0;
        }
        else
        {
                val_92 = 0;
        }
        
            .bigPicture = val_92;
        }
        
        if((val_3.ContainsKey(key:  "smallIconAccentColor")) != false)
        {
                object val_47 = val_3.Item["smallIconAccentColor"];
            if(val_47 != null)
        {
                var val_48 = (null == null) ? (val_47) : 0;
        }
        else
        {
                val_93 = 0;
        }
        
            .smallIconAccentColor = val_93;
        }
        
        if((val_3.ContainsKey(key:  "ledColor")) != false)
        {
                object val_50 = val_3.Item["ledColor"];
            if(val_50 != null)
        {
                var val_51 = (null == null) ? (val_50) : 0;
        }
        else
        {
                val_94 = 0;
        }
        
            .ledColor = val_94;
        }
        
        if((val_3.ContainsKey(key:  "lockScreenVisibility")) != false)
        {
                .lockScreenVisibility = System.Convert.ToInt32(value:  val_3.Item["lockScreenVisibility"]);
        }
        
        if((val_3.ContainsKey(key:  "groupKey")) != false)
        {
                object val_56 = val_3.Item["groupKey"];
            if(val_56 != null)
        {
                var val_57 = (null == null) ? (val_56) : 0;
        }
        else
        {
                val_95 = 0;
        }
        
            .groupKey = val_95;
        }
        
        if((val_3.ContainsKey(key:  "groupMessage")) != false)
        {
                object val_59 = val_3.Item["groupMessage"];
            if(val_59 != null)
        {
                var val_60 = (null == null) ? (val_59) : 0;
        }
        else
        {
                val_96 = 0;
        }
        
            .groupMessage = val_96;
        }
        
        if((val_3.ContainsKey(key:  "fromProjectNumber")) != false)
        {
                object val_62 = val_3.Item["fromProjectNumber"];
            if(val_62 != null)
        {
                var val_63 = (null == null) ? (val_62) : 0;
        }
        else
        {
                val_97 = 0;
        }
        
            .fromProjectNumber = val_97;
        }
        
        .payload = val_2;
        if((jsonObject.ContainsKey(key:  "isAppInFocus")) != false)
        {
                jsonObject.Item["isAppInFocus"].System.IDisposable.Dispose();
            .isAppInFocus = null;
        }
        
        if((jsonObject.ContainsKey(key:  "shown")) != false)
        {
                jsonObject.Item["shown"].System.IDisposable.Dispose();
            .shown = null;
        }
        
        if((jsonObject.ContainsKey(key:  "silentNotification")) != false)
        {
                jsonObject.Item["silentNotification"].System.IDisposable.Dispose();
            .silentNotification = null;
        }
        
        if((jsonObject.ContainsKey(key:  "androidNotificationId")) != false)
        {
                .androidNotificationId = System.Convert.ToInt32(value:  jsonObject.Item["androidNotificationId"]);
        }
        
        if((jsonObject.ContainsKey(key:  "displayType")) == false)
        {
                return (OSNotification)new OSNotification();
        }
        
        .displayType = System.Convert.ToInt32(value:  jsonObject.Item["displayType"]);
        return (OSNotification)new OSNotification();
        label_34:
        object val_76 = Json.Parser.Parse(jsonString:  val_25);
        if(val_2 != null)
        {
            goto label_109;
        }
        
        label_44:
        object val_77 = Json.Parser.Parse(jsonString:  val_30);
        if(val_2 != null)
        {
            goto label_111;
        }
        
        throw new NullReferenceException();
    }
    private void onPushNotificationReceived(string jsonString)
    {
        string val_3;
        var val_4;
        var val_5;
        val_3 = jsonString;
        val_4 = null;
        val_4 = null;
        if(null == 0)
        {
                return;
        }
        
        if(val_3 != null)
        {
                object val_1 = Json.Parser.Parse(jsonString:  val_3);
            val_3 = 0;
        }
        
        val_5 = null;
        val_5 = null;
        Invoke(notification:  DictionaryToNotification(jsonObject:  null));
    }
    private void onPushNotificationOpened(string jsonString)
    {
        var val_15;
        string val_16;
        var val_17;
        val_15 = null;
        val_15 = null;
        if(null == 0)
        {
                return;
        }
        
        if(jsonString != null)
        {
                object val_1 = Json.Parser.Parse(jsonString:  jsonString);
        }
        
        if((0.ContainsKey(key:  "action")) != false)
        {
                object val_4 = 0.Item["action"];
            if((val_4.ContainsKey(key:  "actionID")) != false)
        {
                object val_6 = val_4.Item["actionID"];
            if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_16 = 0;
        }
        
            .actionID = val_16;
        }
        
            if((val_4.ContainsKey(key:  "type")) != false)
        {
                .type = System.Convert.ToInt32(value:  val_4.Item["type"]);
        }
        
        }
        
        object val_13 = 0.Item["notification"];
        .action = new OSNotificationAction();
        .notification = val_13.DictionaryToNotification(jsonObject:  val_13);
        val_17 = null;
        val_17 = null;
        Invoke(result:  new OSNotificationOpenedResult());
    }
    private void onIdsAvailable(string jsonString)
    {
        string val_15;
        string val_16;
        string val_17;
        string val_18;
        var val_19;
        var val_20;
        val_15 = jsonString;
        val_16 = val_15;
        if((System.String.IsNullOrEmpty(value:  val_16)) == true)
        {
                return;
        }
        
        if((Json.Parser.Parse(jsonString:  val_15).isValidDelegate(jsonObject:  0)) == false)
        {
                return;
        }
        
        object val_4 = 0.Item["delegate_id"];
        if(val_4 != null)
        {
                var val_5 = (null == null) ? (val_4) : 0;
        }
        else
        {
                val_15 = 0;
        }
        
        object val_15 = Json.Parser.Parse(jsonString:  0.Item["response"]);
        object val_9 = val_15.Item["userId"];
        if(val_9 != null)
        {
                var val_10 = (null == null) ? (val_9) : 0;
        }
        else
        {
                val_17 = 0;
        }
        
        object val_11 = val_15.Item["pushToken"];
        if(val_11 != null)
        {
                val_15 = (null == null) ? (val_11) : 0;
        }
        else
        {
                val_18 = 0;
        }
        
        val_19 = null;
        val_19 = null;
        if((OneSignal.gameObjectName.ContainsKey(key:  val_15)) == false)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        bool val_14 = OneSignal.gameObjectName.Remove(key:  val_15);
        if(null == null)
        {
                OneSignal.gameObjectName.Item[val_15].Invoke(playerID:  val_17, pushToken:  val_18);
            return;
        }
    
    }
    private void onTagsReceived(string jsonString)
    {
        string val_14;
        string val_15;
        var val_16;
        var val_17;
        val_14 = jsonString;
        val_15 = val_14;
        if((System.String.IsNullOrEmpty(value:  val_15)) == true)
        {
                return;
        }
        
        if((Json.Parser.Parse(jsonString:  val_14).isValidDelegate(jsonObject:  0)) == false)
        {
                return;
        }
        
        object val_4 = 0.Item["delegate_id"];
        if(val_4 != null)
        {
                var val_5 = (null == null) ? (val_4) : 0;
        }
        else
        {
                val_14 = 0;
        }
        
        object val_7 = 0.Item["response"];
        if(val_7 != null)
        {
                if(null == null)
        {
            goto label_11;
        }
        
        }
        
        label_24:
        label_25:
        if((System.String.IsNullOrEmpty(value:  val_14)) == true)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        if((OneSignal.gameObjectName.ContainsKey(key:  val_14)) == false)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        bool val_11 = OneSignal.gameObjectName.Remove(key:  val_14);
        if(null != null)
        {
            goto label_22;
        }
        
        OneSignal.gameObjectName.Item[val_14].Invoke(tags:  0);
        return;
        label_11:
        object val_12 = Json.Parser.Parse(jsonString:  val_7);
        if(val_12 == null)
        {
            goto label_24;
        }
        
        var val_13 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_12) : 0;
        goto label_25;
        label_22:
    }
    private void onPostNotificationSuccess(string jsonString)
    {
        string val_17;
        string val_18;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_19;
        string val_20;
        var val_21;
        var val_22;
        val_17 = jsonString;
        val_18 = val_17;
        if((System.String.IsNullOrEmpty(value:  val_18)) == true)
        {
                return;
        }
        
        val_19 = 0;
        if((Json.Parser.Parse(jsonString:  val_17).isValidSuccessFailureDelegate(jsonObject:  val_19)) == false)
        {
                return;
        }
        
        object val_17 = Json.Parser.Parse(jsonString:  val_19.Item["delegate_id"]);
        object val_6 = val_17.Item["success"];
        if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_17 = 0;
        }
        
        object val_9 = val_17.Item["failure"];
        if(val_9 != null)
        {
                val_17 = (null == null) ? (val_9) : 0;
        }
        else
        {
                val_20 = 0;
        }
        
        object val_10 = val_19.Item["response"];
        if(val_10 != null)
        {
                if(null == null)
        {
            goto label_18;
        }
        
        }
        
        label_31:
        val_19 = 0;
        label_32:
        val_21 = null;
        val_21 = null;
        if((OneSignal.gameObjectName.ContainsKey(key:  val_17)) == false)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        bool val_13 = OneSignal.gameObjectName.Remove(key:  val_17);
        bool val_14 = OneSignal.gameObjectName.Remove(key:  val_20);
        if(null != null)
        {
            goto label_29;
        }
        
        OneSignal.gameObjectName.Item[val_17].Invoke(response:  val_19);
        return;
        label_18:
        object val_15 = Json.Parser.Parse(jsonString:  val_10);
        if(val_15 == null)
        {
            goto label_31;
        }
        
        var val_16 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_15) : 0;
        goto label_32;
        label_29:
    }
    private void onPostNotificationFailed(string jsonString)
    {
        string val_17;
        string val_18;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_19;
        string val_20;
        var val_21;
        var val_22;
        val_17 = jsonString;
        val_18 = val_17;
        if((System.String.IsNullOrEmpty(value:  val_18)) == true)
        {
                return;
        }
        
        val_19 = 0;
        if((Json.Parser.Parse(jsonString:  val_17).isValidSuccessFailureDelegate(jsonObject:  val_19)) == false)
        {
                return;
        }
        
        object val_17 = Json.Parser.Parse(jsonString:  val_19.Item["delegate_id"]);
        object val_6 = val_17.Item["success"];
        if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_17 = 0;
        }
        
        object val_9 = val_17.Item["failure"];
        if(val_9 != null)
        {
                val_17 = (null == null) ? (val_9) : 0;
        }
        else
        {
                val_20 = 0;
        }
        
        object val_10 = val_19.Item["response"];
        if(val_10 != null)
        {
                if(null == null)
        {
            goto label_18;
        }
        
        }
        
        label_31:
        val_19 = 0;
        label_32:
        val_21 = null;
        val_21 = null;
        if((OneSignal.gameObjectName.ContainsKey(key:  val_20)) == false)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        bool val_13 = OneSignal.gameObjectName.Remove(key:  val_17);
        bool val_14 = OneSignal.gameObjectName.Remove(key:  val_20);
        if(null != null)
        {
            goto label_29;
        }
        
        OneSignal.gameObjectName.Item[val_20].Invoke(response:  val_19);
        return;
        label_18:
        object val_15 = Json.Parser.Parse(jsonString:  val_10);
        if(val_15 == null)
        {
            goto label_31;
        }
        
        var val_16 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_15) : 0;
        goto label_32;
        label_29:
    }
    private void onExternalUserIdUpdateCompletion(string jsonString)
    {
        string val_13;
        string val_14;
        var val_15;
        var val_16;
        val_13 = jsonString;
        val_14 = val_13;
        if((System.String.IsNullOrEmpty(value:  val_14)) == true)
        {
                return;
        }
        
        if((Json.Parser.Parse(jsonString:  val_13).isValidDelegate(jsonObject:  0)) == false)
        {
                return;
        }
        
        string val_4 = 0.Item["delegate_id"];
        if(val_4 != null)
        {
                var val_5 = (null == null) ? (val_4) : 0;
        }
        else
        {
                val_13 = 0;
        }
        
        string val_7 = 0.Item["response"];
        if(val_7 != null)
        {
                if(null == null)
        {
            goto label_11;
        }
        
        }
        
        label_23:
        label_24:
        val_15 = null;
        val_15 = null;
        if((OneSignal.gameObjectName.ContainsKey(key:  val_13)) == false)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        bool val_10 = OneSignal.gameObjectName.Remove(key:  val_13);
        if(null != null)
        {
            goto label_21;
        }
        
        OneSignal.gameObjectName.Item[val_13].Invoke(results:  0);
        return;
        label_11:
        object val_11 = Json.Parser.Parse(jsonString:  val_7);
        if(val_11 == null)
        {
            goto label_23;
        }
        
        var val_12 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_11) : 0;
        goto label_24;
        label_21:
    }
    private void onSetEmailSuccess(string jsonString)
    {
        string val_15;
        string val_16;
        string val_17;
        var val_18;
        var val_19;
        val_15 = jsonString;
        val_16 = val_15;
        if((System.String.IsNullOrEmpty(value:  val_16)) == true)
        {
                return;
        }
        
        if((Json.Parser.Parse(jsonString:  val_15).isValidSuccessFailureDelegate(jsonObject:  0)) == false)
        {
                return;
        }
        
        object val_15 = Json.Parser.Parse(jsonString:  0.Item["delegate_id"]);
        object val_6 = val_15.Item["success"];
        if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_15 = 0;
        }
        
        object val_9 = val_15.Item["failure"];
        if(val_9 != null)
        {
                val_15 = (null == null) ? (val_9) : 0;
        }
        else
        {
                val_17 = 0;
        }
        
        object val_10 = 0.Item["response"];
        val_18 = null;
        val_18 = null;
        if((OneSignal.gameObjectName.ContainsKey(key:  val_15)) == false)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        bool val_13 = OneSignal.gameObjectName.Remove(key:  val_15);
        bool val_14 = OneSignal.gameObjectName.Remove(key:  val_17);
        if(null == null)
        {
                OneSignal.gameObjectName.Item[val_15].Invoke();
            return;
        }
    
    }
    private void onSetEmailFailure(string jsonString)
    {
        string val_17;
        string val_18;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_19;
        string val_20;
        var val_21;
        var val_22;
        val_17 = jsonString;
        val_18 = val_17;
        if((System.String.IsNullOrEmpty(value:  val_18)) == true)
        {
                return;
        }
        
        val_19 = 0;
        if((Json.Parser.Parse(jsonString:  val_17).isValidSuccessFailureDelegate(jsonObject:  val_19)) == false)
        {
                return;
        }
        
        object val_17 = Json.Parser.Parse(jsonString:  val_19.Item["delegate_id"]);
        object val_6 = val_17.Item["success"];
        if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_17 = 0;
        }
        
        object val_9 = val_17.Item["failure"];
        if(val_9 != null)
        {
                val_17 = (null == null) ? (val_9) : 0;
        }
        else
        {
                val_20 = 0;
        }
        
        object val_10 = val_19.Item["response"];
        if(val_10 != null)
        {
                if(null == null)
        {
            goto label_18;
        }
        
        }
        
        label_31:
        val_19 = 0;
        label_32:
        val_21 = null;
        val_21 = null;
        if((OneSignal.gameObjectName.ContainsKey(key:  val_20)) == false)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        bool val_13 = OneSignal.gameObjectName.Remove(key:  val_17);
        bool val_14 = OneSignal.gameObjectName.Remove(key:  val_20);
        if(null != null)
        {
            goto label_29;
        }
        
        OneSignal.gameObjectName.Item[val_20].Invoke(error:  val_19);
        return;
        label_18:
        object val_15 = Json.Parser.Parse(jsonString:  val_10);
        if(val_15 == null)
        {
            goto label_31;
        }
        
        var val_16 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_15) : 0;
        goto label_32;
        label_29:
    }
    private void onLogoutEmailSuccess(string jsonString)
    {
        string val_15;
        string val_16;
        string val_17;
        var val_18;
        var val_19;
        val_15 = jsonString;
        val_16 = val_15;
        if((System.String.IsNullOrEmpty(value:  val_16)) == true)
        {
                return;
        }
        
        if((Json.Parser.Parse(jsonString:  val_15).isValidSuccessFailureDelegate(jsonObject:  0)) == false)
        {
                return;
        }
        
        object val_15 = Json.Parser.Parse(jsonString:  0.Item["delegate_id"]);
        object val_6 = val_15.Item["success"];
        if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_15 = 0;
        }
        
        object val_9 = val_15.Item["failure"];
        if(val_9 != null)
        {
                val_15 = (null == null) ? (val_9) : 0;
        }
        else
        {
                val_17 = 0;
        }
        
        object val_10 = 0.Item["response"];
        val_18 = null;
        val_18 = null;
        if((OneSignal.gameObjectName.ContainsKey(key:  val_15)) == false)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        bool val_13 = OneSignal.gameObjectName.Remove(key:  val_15);
        bool val_14 = OneSignal.gameObjectName.Remove(key:  val_17);
        if(null == null)
        {
                OneSignal.gameObjectName.Item[val_15].Invoke();
            return;
        }
    
    }
    private void onLogoutEmailFailure(string jsonString)
    {
        string val_17;
        string val_18;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_19;
        string val_20;
        var val_21;
        var val_22;
        val_17 = jsonString;
        val_18 = val_17;
        if((System.String.IsNullOrEmpty(value:  val_18)) == true)
        {
                return;
        }
        
        val_19 = 0;
        if((Json.Parser.Parse(jsonString:  val_17).isValidSuccessFailureDelegate(jsonObject:  val_19)) == false)
        {
                return;
        }
        
        object val_17 = Json.Parser.Parse(jsonString:  val_19.Item["delegate_id"]);
        object val_6 = val_17.Item["success"];
        if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_17 = 0;
        }
        
        object val_9 = val_17.Item["failure"];
        if(val_9 != null)
        {
                val_17 = (null == null) ? (val_9) : 0;
        }
        else
        {
                val_20 = 0;
        }
        
        object val_10 = val_19.Item["response"];
        if(val_10 != null)
        {
                if(null == null)
        {
            goto label_18;
        }
        
        }
        
        label_31:
        val_19 = 0;
        label_32:
        val_21 = null;
        val_21 = null;
        if((OneSignal.gameObjectName.ContainsKey(key:  val_20)) == false)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        bool val_13 = OneSignal.gameObjectName.Remove(key:  val_17);
        bool val_14 = OneSignal.gameObjectName.Remove(key:  val_20);
        if(null != null)
        {
            goto label_29;
        }
        
        OneSignal.gameObjectName.Item[val_20].Invoke(error:  val_19);
        return;
        label_18:
        object val_15 = Json.Parser.Parse(jsonString:  val_10);
        if(val_15 == null)
        {
            goto label_31;
        }
        
        var val_16 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_15) : 0;
        goto label_32;
        label_29:
    }
    private void onSendOutcomeSuccess(string jsonString)
    {
        string val_18;
        string val_19;
        string val_20;
        OSOutcomeEvent val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        val_18 = jsonString;
        val_19 = val_18;
        if((System.String.IsNullOrEmpty(value:  val_19)) == true)
        {
                return;
        }
        
        if((Json.Parser.Parse(jsonString:  val_18).isValidDelegate(jsonObject:  0)) == false)
        {
                return;
        }
        
        object val_4 = 0.Item["delegate_id"];
        if(val_4 != null)
        {
                var val_5 = (null == null) ? (val_4) : 0;
        }
        else
        {
                val_18 = 0;
        }
        
        object val_7 = 0.Item["response"];
        if(val_7 != null)
        {
                var val_8 = (null == null) ? (val_7) : 0;
        }
        else
        {
                val_20 = 0;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_20)) != false)
        {
                OSOutcomeEvent val_10 = null;
            val_21 = val_10;
            val_10 = new OSOutcomeEvent();
        }
        else
        {
                if(val_20 != 0)
        {
                val_22 = Json.Parser.Parse(jsonString:  val_20);
        }
        else
        {
                val_22 = 0;
        }
        
            val_21 = new OSOutcomeEvent();
            val_23 = 0;
            val_21 = new OSOutcomeEvent(outcomeDict:  null);
        }
        
        val_24 = null;
        val_24 = null;
        if((OneSignal.gameObjectName.ContainsKey(key:  val_18)) == false)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        if(OneSignal.gameObjectName.Item[val_18] == null)
        {
                return;
        }
        
        val_26 = null;
        val_26 = null;
        bool val_17 = OneSignal.gameObjectName.Remove(key:  val_18);
        if(null == null)
        {
                OneSignal.gameObjectName.Item[val_18].Invoke(outcomeEvent:  new OSOutcomeEvent());
            return;
        }
    
    }
    private void onOSPermissionChanged(string stateChangesJSONString)
    {
        var val_2 = null;
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 42;
            OneSignalPlatform val_1 = oneSignalPlatform + val_4;
        }
        
        OneSignal.internalPermissionObserver.Invoke(stateChanges:  OneSignal.oneSignalPlatform.ParseOSPermissionStateChanges(stateChangesJSONString:  stateChangesJSONString));
    }
    private void onOSSubscriptionChanged(string stateChangesJSONString)
    {
        var val_2 = null;
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 43;
            OneSignalPlatform val_1 = oneSignalPlatform + val_4;
        }
        
        OneSignal.internalSubscriptionObserver.Invoke(stateChanges:  OneSignal.oneSignalPlatform.ParseOSSubscriptionStateChanges(stateChangesJSONString:  stateChangesJSONString));
    }
    private void onOSEmailSubscriptionChanged(string stateChangesJSONString)
    {
        var val_2 = null;
        var val_3 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_3 = val_3 + 1;
        }
        else
        {
                var val_4 = mem[1152921505019609096];
            val_4 = val_4 + 44;
            OneSignalPlatform val_1 = oneSignalPlatform + val_4;
        }
        
        OneSignal.internalEmailSubscriptionObserver.Invoke(stateChanges:  OneSignal.oneSignalPlatform.ParseOSEmailSubscriptionStateChanges(stateChangesJSONString:  stateChangesJSONString));
    }
    private void onPromptForPushNotificationsWithUserResponse(string accepted)
    {
        null = null;
        OneSignal.notificationUserResponseDelegate.Invoke(accepted:  System.Convert.ToBoolean(value:  accepted));
    }
    private void onInAppMessageClicked(string jsonString)
    {
        var val_14;
        string val_15;
        string val_16;
        var val_17;
        val_14 = null;
        val_14 = null;
        if(null == 0)
        {
                return;
        }
        
        if(jsonString != null)
        {
                object val_1 = Json.Parser.Parse(jsonString:  jsonString);
        }
        
        if((0.ContainsKey(key:  "click_name")) != false)
        {
                object val_4 = 0.Item["click_name"];
            if(val_4 != null)
        {
                var val_5 = (null == null) ? (val_4) : 0;
        }
        else
        {
                val_15 = 0;
        }
        
            .clickName = val_15;
        }
        
        if((0.ContainsKey(key:  "click_url")) != false)
        {
                object val_8 = 0.Item["click_url"];
            if(val_8 != null)
        {
                var val_9 = (null == null) ? (val_8) : 0;
        }
        else
        {
                val_16 = 0;
        }
        
            .clickUrl = val_16;
        }
        
        if((0.ContainsKey(key:  "closes_message")) != false)
        {
                0.Item["closes_message"].System.IDisposable.Dispose();
            .closesMessage = null;
        }
        
        if((0.ContainsKey(key:  "first_click")) != false)
        {
                0.Item["first_click"].System.IDisposable.Dispose();
            .firstClick = null;
        }
        
        val_17 = null;
        val_17 = null;
        Invoke(action:  new OSInAppMessageAction());
    }
    private bool isValidDelegate(System.Collections.Generic.Dictionary<string, object> jsonObject)
    {
        if((jsonObject.ContainsKey(key:  "delegate_id")) == false)
        {
                return false;
        }
        
        return jsonObject.ContainsKey(key:  "response");
    }
    private bool isValidSuccessFailureDelegate(System.Collections.Generic.Dictionary<string, object> jsonObject)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = jsonObject;
        if((this.isValidDelegate(jsonObject:  val_5 = jsonObject)) == false)
        {
                return false;
        }
        
        val_5 = Json.Parser.Parse(jsonString:  val_5.Item["delegate_id"]);
        if((val_5.ContainsKey(key:  "success")) == false)
        {
                return false;
        }
        
        return val_5.ContainsKey(key:  "failure");
    }
    public OneSignal()
    {
    
    }
    private static OneSignal()
    {
        OneSignal.builder = 0;
        OneSignal.oneSignalPlatform = 0;
        OneSignal.logLevel = 4;
        OneSignal.visualLogLevel = 0;
        OneSignal.requiresUserConsent = false;
        OneSignal._inFocusDisplayType = 1;
    }

}
