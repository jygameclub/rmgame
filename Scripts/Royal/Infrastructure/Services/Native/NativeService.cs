using UnityEngine;

namespace Royal.Infrastructure.Services.Native
{
    public class NativeService : IContextUnit
    {
        // Fields
        public readonly Royal.Infrastructure.Services.Native.Purchase.PurchaseManager purchaseManager;
        public readonly Royal.Infrastructure.Services.Native.CloudBackup.BackupManager backupManager;
        private readonly Plugins.Dream.NativeLibrary library;
        private int memoryWarningCount;
        private readonly string <DeviceId>k__BackingField;
        private string <AdvertisingId>k__BackingField;
        private int <LegacyNotchHeight>k__BackingField;
        
        // Properties
        public int Id { get; }
        public string DeviceId { get; }
        public string AdvertisingId { get; set; }
        public int LegacyNotchHeight { get; set; }
        
        // Methods
        public int get_Id()
        {
            return 19;
        }
        public string get_DeviceId()
        {
            return (string)this.<DeviceId>k__BackingField;
        }
        public string get_AdvertisingId()
        {
            return (string)this.<AdvertisingId>k__BackingField;
        }
        private void set_AdvertisingId(string value)
        {
            this.<AdvertisingId>k__BackingField = value;
        }
        public int get_LegacyNotchHeight()
        {
            return (int)this.<LegacyNotchHeight>k__BackingField;
        }
        private void set_LegacyNotchHeight(int value)
        {
            this.<LegacyNotchHeight>k__BackingField = value;
        }
        public NativeService()
        {
            Plugins.Dream.NativeLibrary val_1 = Plugins.Dream.NativeLibrary.LoadNativeLibrary();
            this.library = val_1;
            this.purchaseManager = new Royal.Infrastructure.Services.Native.Purchase.PurchaseManager(nativeLibrary:  val_1);
            this.backupManager = new Royal.Infrastructure.Services.Native.CloudBackup.BackupManager(nativeLibrary:  this.library);
            this.<DeviceId>k__BackingField = this.library.GetDeviceId();
            object[] val_5 = new object[1];
            val_5[0] = this.<DeviceId>k__BackingField;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "DeviceId: {0}", values:  val_5);
            this.<AdvertisingId>k__BackingField = UnityEngine.PlayerPrefs.GetString(key:  "AdvertisingId", defaultValue:  System.String.alignConst);
            this.RequestAdvertisingId();
        }
        public void Bind()
        {
            var val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Start NativeService initialization.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.library.Initialize();
            this.<LegacyNotchHeight>k__BackingField = this.library.GetLegacyNotchHeight();
            UnityEngine.Application.add_lowMemory(value:  new Application.LowMemoryCallback(object:  this, method:  System.Void Royal.Infrastructure.Services.Native.NativeService::OnLowMemory()));
        }
        public void RequestStoreReview()
        {
            if(this.library != null)
            {
                    this.library.RequestStoreReview();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void ShowAlertMessage(bool show, string title, string message, string action)
        {
            object[] val_2 = new object[1];
            val_2[0] = show;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Show native alert: {0}", values:  val_2);
            this.library.ShowAlertMessage(show:  show, title:  title, message:  message, action:  action);
        }
        public void ShowConsentMessage()
        {
            var val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Show native consent.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.library.remove_OnConsentResult(value:  new System.Action<System.String>(object:  this, method:  System.Void Royal.Infrastructure.Services.Native.NativeService::OnConsentResult(string message)));
            this.library.add_OnConsentResult(value:  new System.Action<System.String>(object:  this, method:  System.Void Royal.Infrastructure.Services.Native.NativeService::OnConsentResult(string message)));
            this.library.ShowConsentMessage(title:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "GDPRTitle", ignoreArabicFix:  true), message:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "GDPRText", ignoreArabicFix:  true), action:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "OK", ignoreArabicFix:  true), termsText:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "GDPRTerms", ignoreArabicFix:  true), termsUrl:  "https://dreamgames.com/terms", privacyText:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "GDPRPrivacy", ignoreArabicFix:  true), privacyUrl:  "https://dreamgames.com/privacy");
        }
        public void HideConsentMessage()
        {
            if(this.library != null)
            {
                    this.library.HideConsentMessage();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void StartIntentAction(string actionName)
        {
            if(this.library != null)
            {
                    this.library.StartIntentAction(actionName:  actionName);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void RequestAdvertisingId()
        {
            bool val_2 = UnityEngine.Application.RequestAdvertisingIdentifierAsync(delegateMethod:  new Application.AdvertisingIdentifierCallback(object:  this, method:  System.Void Royal.Infrastructure.Services.Native.NativeService::<RequestAdvertisingId>b__24_0(string advertisingId, bool trackingEnabled, string error)));
        }
        private void OnLowMemory()
        {
            Firebase.Analytics.Parameter val_6;
            var val_7;
            int val_6 = this.memoryWarningCount;
            val_6 = val_6 + 1;
            this.memoryWarningCount = val_6;
            object[] val_1 = new object[1];
            val_1[0] = this.memoryWarningCount;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  13, log:  "Received {0}. low memory warning", values:  val_1);
            Firebase.Analytics.Parameter[] val_2 = new Firebase.Analytics.Parameter[1];
            Firebase.Analytics.Parameter val_4 = null;
            val_6 = val_4;
            val_4 = new Firebase.Analytics.Parameter(parameterName:  "memory", parameterValue:  (long)UnityEngine.SystemInfo.systemMemorySize);
            val_2[0] = val_6;
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  "low_memory", parameters:  val_2);
            if(this.memoryWarningCount < 3)
            {
                    return;
            }
            
            this.memoryWarningCount = 0;
            UnityEngine.AsyncOperation val_5 = UnityEngine.Resources.UnloadUnusedAssets();
            val_6 = public static T[] System.Array::Empty<System.Object>();
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Unload unused assets", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private void OnConsentResult(string message)
        {
            var val_6;
            object[] val_1 = new object[1];
            val_1[0] = message;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Native consent result = {0}", values:  val_1);
            if((message.StartsWith(value:  "notshown")) != false)
            {
                    Royal.Infrastructure.Contexts.Units.App.AppManager val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
                val_6 = 0;
            }
            else
            {
                    if((message.StartsWith(value:  "http")) != false)
            {
                    UnityEngine.Application.OpenURL(url:  message);
                return;
            }
            
                Royal.Infrastructure.Contexts.Units.App.AppManager val_5 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
                val_6 = 1;
            }
            
            val_5.consentHelper.GiveConsent(isShown:  true);
        }
        public float GetKeyboardHeight()
        {
            if(this.library != null)
            {
                    return this.library.GetKeyboardHeight();
            }
            
            throw new NullReferenceException();
        }
        private void <RequestAdvertisingId>b__24_0(string advertisingId, bool trackingEnabled, string error)
        {
            if((System.String.IsNullOrEmpty(value:  error)) != false)
            {
                    this.<AdvertisingId>k__BackingField = advertisingId;
                UnityEngine.PlayerPrefs.SetString(key:  "AdvertisingId", value:  advertisingId);
                object[] val_2 = new object[2];
                val_2[0] = advertisingId;
                val_2[1] = trackingEnabled;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "AdvertisingId: {0} / {1}", values:  val_2);
                return;
            }
            
            object[] val_4 = new object[1];
            val_4[0] = error;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Error on requesting AdvertisingId: {0}", values:  val_4);
        }
    
    }

}
