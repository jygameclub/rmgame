using UnityEngine;

namespace Royal.Infrastructure.Services.Helpshift
{
    public class HelpshiftManager : IContextUnit
    {
        // Fields
        private const string GameObjectName = "HelpshiftProxy";
        private const string ApiKey = "2cd6ee2e8f382142d36957f518605595";
        private const string DomainName = "dreamgames.helpshift.com";
        private const string AndroidAppId = "dreamgames_platform_20200701114225882-8b0e714dfa1890f";
        private const string iOSAppId = "dreamgames_platform_20200701114048387-66e085a39ba3af7";
        private Royal.Infrastructure.Services.Login.LoginService loginService;
        public int messageCount;
        public Royal.Scenes.Home.Ui.Sections.Settings.SettingsSection settingsSection;
        private readonly Helpshift.HelpshiftSdk helpshiftSdk;
        
        // Properties
        public int Id { get; }
        private static string AppId { get; }
        
        // Methods
        public int get_Id()
        {
            return 1;
        }
        private static string get_AppId()
        {
            return "dreamgames_platform_20200701114225882-8b0e714dfa1890f";
        }
        public HelpshiftManager()
        {
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsEditor != false)
            {
                    return;
            }
            
            Helpshift.HelpshiftSdk val_2 = Helpshift.HelpshiftSdk.getInstance();
            this.helpshiftSdk = val_2;
            val_2.install(apiKey:  "2cd6ee2e8f382142d36957f518605595", domainName:  "dreamgames.helpshift.com", appId:  "dreamgames_platform_20200701114225882-8b0e714dfa1890f", config:  Royal.Infrastructure.Services.Helpshift.HelpshiftManager.GetInstallConfig());
            this.helpshiftSdk.registerDelegates();
            Royal.Infrastructure.Services.Helpshift.HelpshiftCallbacks val_5 = new UnityEngine.GameObject(name:  "HelpshiftProxy").AddComponent<Royal.Infrastructure.Services.Helpshift.HelpshiftCallbacks>();
            val_5 = this;
            UnityEngine.Object.DontDestroyOnLoad(target:  val_5);
        }
        public void Bind()
        {
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsEditor != false)
            {
                    return;
            }
            
            this.loginService = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Login.LoginService>(id:  20);
            this.UpdateUserId();
            this.CheckActiveConversations();
            System.Action val_4 = static_value_02DC1B30;
            val_4 = new System.Action(object:  this, method:  public System.Void Royal.Infrastructure.Services.Helpshift.HelpshiftManager::CheckActiveConversations());
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3).add_OnApplicationResume(value:  val_4);
        }
        public void UpdateUserId()
        {
            var val_8;
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsEditor == true)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  typeof(Royal.Player.Context.Data.UserId).__il2cppRuntimeField_28)) != false)
            {
                    val_8 = UnityEngine.SystemInfo.deviceName;
            }
            
            this.helpshiftSdk.login(helpshiftUser:  new HelpshiftUser.Builder(identifier:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name.ToString(), email:  0).setName(name:  typeof(Royal.Player.Context.Data.UserId).__il2cppRuntimeField_28).build());
        }
        public void RegisterPushToken(string playerId, string token)
        {
            int val_3;
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsEditor != false)
            {
                    return;
            }
            
            this.helpshiftSdk.registerDeviceToken(deviceToken:  token);
            object[] val_2 = new object[2];
            val_3 = val_2.Length;
            val_2[0] = playerId;
            if(token != null)
            {
                    val_3 = val_2.Length;
            }
            
            val_2[1] = token;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  12, log:  "Helpshift device token is registered {0} : {1}", values:  val_2);
        }
        public void Show()
        {
            var val_3;
            var val_4;
            bool val_1 = Royal.Infrastructure.Utils.Native.DeviceHelper.IsEditor;
            if(val_1 != false)
            {
                    val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  12, log:  "Helpshift is not supported in editor.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = val_1.GetConversationConfig();
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            if(this.messageCount >= 1)
            {
                    Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  12, log:  "Show Helpshift Conversation", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                this.helpshiftSdk.showConversation(configMap:  val_2);
                return;
            }
            
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  12, log:  "Show Helpshift FAQ", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.helpshiftSdk.showFAQs(configMap:  val_2);
        }
        public void CheckActiveConversations()
        {
            if(this.loginService.ConnectionInProgress != false)
            {
                    return;
            }
            
            this.helpshiftSdk.requestUnreadMessagesCount(isAsync:  true);
            this.helpshiftSdk.checkIfConversationActive();
        }
        public void UpdateSettingsSection(bool enable)
        {
            if(this.settingsSection == 0)
            {
                    return;
            }
            
            this.settingsSection.UpdateNotificationIcons(enable:  enable);
        }
        private static System.Collections.Generic.Dictionary<string, object> GetInstallConfig()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "unityGameObject", value:  "HelpshiftProxy");
            val_1.Add(key:  "enableInAppNotification", value:  "no");
            val_1.Add(key:  "enableDefaultFallbackLanguage", value:  "yes");
            val_1.Add(key:  "disableEntryExitAnimations", value:  "no");
            val_1.Add(key:  "enableInboxPolling", value:  "no");
            val_1.Add(key:  "enableLogging", value:  "no");
            val_1.Add(key:  "enableAutomaticThemeSwitching", value:  "yes");
            val_1.Add(key:  "disableErrorReporting", value:  "no");
            val_1.Add(key:  "screenOrientation", value:  1);
            val_1.Add(key:  "notificationIcon", value:  "small_notification_icon");
            val_1.Add(key:  "largeNotificationIcon", value:  "large_notification_icon");
            return val_1;
        }
        private System.Collections.Generic.Dictionary<string, object> GetConversationConfig()
        {
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasTeam()) != false)
            {
                    Royal.Player.Context.Units.SocialManager val_3 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
                "N/A" = val_3.<MyTeamName>k__BackingField(val_3.<MyTeamName>k__BackingField) + " - http://prod-admin.royal.drmgms.com/team/"(" - http://prod-admin.royal.drmgms.com/team/") + Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsInLeague()) != false)
            {
                    string val_7 = typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14 + " / "(" / ") + Royal.Player.Context.Data.Persistent.BasicUserData.__il2cppRuntimeField_namespaze;
            }
            
            val_5.Add(key:  "Level", value:  typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14.ToString());
            val_5.Add(key:  "Coins", value:  Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name);
            val_5.Add(key:  "Stars", value:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_14);
            val_5.Add(key:  "Paying User", value:  IsPaidUser);
            val_5.Add(key:  "Device Id", value:  Royal.Infrastructure.Utils.Native.DeviceHelper.DeviceId());
            val_5.Add(key:  "Team", value:  "N/A");
            val_5.Add(key:  "Log", value:  Royal.Infrastructure.Services.Logs.LogUploader.GenerateLogFileUrl());
            System.Collections.Generic.Dictionary<System.String, System.Object> val_12 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            bool val_13 = val_12.Remove(key:  "hs-custom-metadata");
            val_12.Add(key:  "hs-custom-metadata", value:  val_5);
            return val_12;
        }
    
    }

}
