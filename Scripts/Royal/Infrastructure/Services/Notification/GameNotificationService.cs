using UnityEngine;

namespace Royal.Infrastructure.Services.Notification
{
    public class GameNotificationService : IContextUnit
    {
        // Fields
        private System.Action OnDeviceNotificationSettingsChange;
        private bool notificationsAreScheduled;
        private readonly Royal.Infrastructure.Services.Notification.IGameNotificationPlatform platform;
        private bool isNotificationEnabledInDeviceSettings;
        private bool isNotificationEnabledInGameSettings;
        
        // Properties
        public int Id { get; }
        public static string NotificationSettingsUrl { get; }
        private string AppId { get; }
        
        // Methods
        public void add_OnDeviceNotificationSettingsChange(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnDeviceNotificationSettingsChange, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnDeviceNotificationSettingsChange != 1152921527559147616);
            
            return;
            label_2:
        }
        public void remove_OnDeviceNotificationSettingsChange(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnDeviceNotificationSettingsChange, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnDeviceNotificationSettingsChange != 1152921527559284192);
            
            return;
            label_2:
        }
        public int get_Id()
        {
            return 18;
        }
        public static string get_NotificationSettingsUrl()
        {
            return "android.settings.APP_NOTIFICATION_SETTINGS";
        }
        private string get_AppId()
        {
            return "cf64da99-edb7-4c38-9198-55e5c07cfd5b";
        }
        public void Bind()
        {
            this.ClearAllNotifications();
            Royal.Infrastructure.Contexts.Units.App.AppManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            val_1.add_OnApplicationResume(value:  new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Notification.GameNotificationService::OnApplicationResume()));
            val_1.add_OnApplicationPause(value:  new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Notification.GameNotificationService::OnApplicationPause()));
            val_1.add_OnApplicationQuit(value:  new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Notification.GameNotificationService::OnApplicationQuit()));
            this.RequestPermissionIfRuleSatisfied();
            int val_6 = Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.GetInt(db:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService, key:  "Notification", defaultValue:  1);
            this.isNotificationEnabledInGameSettings = (val_6 == 1) ? 1 : 0;
            this.isNotificationEnabledInDeviceSettings = val_6.IsNotificationEnabledInDeviceSettings();
        }
        public void RequestPermissionIfRuleSatisfied()
        {
            if((Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.GetInt(db:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService, key:  "ConsentState", defaultValue:  0)) == 1)
            {
                    return;
            }
            
            this.RequestPermissionAndInitializeOneSignal();
        }
        public void RequestPermissionAndInitializeOneSignal()
        {
            if((Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.GetInt(db:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService, key:  "RequestNotificationPermission", defaultValue:  0)) == 1)
            {
                    this.RequestAuthorization();
            }
            
            OneSignal.StartInit(appID:  "cf64da99-edb7-4c38-9198-55e5c07cfd5b", googleProjectNumber:  0).HandleNotificationOpened(inNotificationOpenedDelegate:  new OneSignal.NotificationOpened(object:  0, method:  static System.Void Royal.Infrastructure.Services.Notification.GameNotificationService::HandleNotificationOpened(OSNotificationOpenedResult result))).HandleNotificationReceived(inNotificationReceivedDelegate:  new OneSignal.NotificationReceived(object:  this, method:  System.Void Royal.Infrastructure.Services.Notification.GameNotificationService::HandleNotificationReceived(OSNotification notification))).InFocusDisplaying(display:  0).EndInit();
            OneSignal.EnableSound(enable:  false);
            OneSignal.EnableVibrate(enable:  false);
            OneSignal.IdsAvailable(inIdsAvailableDelegate:  new OneSignal.IdsAvailableCallback(object:  0, method:  static System.Void Royal.Infrastructure.Services.Notification.GameNotificationService::IdsAvailable(string playerID, string pushToken)));
            OneSignal.ClearOneSignalNotifications();
            Royal.Infrastructure.Services.Notification.GameNotificationService.AddUserTags();
        }
        public void RequestAuthorization()
        {
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.SetInt(db:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService, key:  "RequestNotificationPermission", value:  0, synced:  false);
            var val_6 = 0;
            if(mem[1152921505134145536] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    var val_7 = mem[1152921505134145544];
                val_7 = val_7 + 5;
                Royal.Infrastructure.Services.Notification.IGameNotificationPlatform val_3 = 1152921505134108672 + val_7;
            }
            
            UnityEngine.Coroutine val_5 = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  this.platform.RequestAuthorization());
        }
        private static void AddUserTags()
        {
            string val_4;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<IsTemp>k__BackingField) == true)
            {
                    return;
            }
            
            val_4 = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name.ToString();
            OneSignal.SetExternalUserId(externalId:  val_4);
            System.Collections.Generic.Dictionary<System.String, System.String> val_3 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            val_3.Add(key:  "UserId", value:  val_4);
            val_3.Add(key:  "TimeZone", value:  Royal.Infrastructure.Services.Backend.Http.TimeHelper.GetTimeZoneInNumberRepresentation());
            OneSignal.SendTags(tags:  val_3);
        }
        private static bool IsOneSignalInitialized()
        {
            null = null;
            return (bool)(OneSignal.builder != 0) ? 1 : 0;
        }
        public static void UpdateUserLevelTag()
        {
            if(Royal.Infrastructure.Services.Notification.GameNotificationService.IsOneSignalInitialized() == false)
            {
                    return;
            }
            
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<IsTemp>k__BackingField) == true)
            {
                    return;
            }
            
            OneSignal.SendTag(tagName:  "Level", tagValue:  typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14.ToString());
        }
        public static void TryUpdateUserKingsCupEventIdTag(long eventId)
        {
            string val_3;
            var val_4;
            val_3 = eventId;
            val_4 = 17394;
            val_4 = 41188;
            if(val_3 == 0)
            {
                    return;
            }
            
            if(Royal.Infrastructure.Services.Notification.GameNotificationService.IsOneSignalInitialized() == false)
            {
                    return;
            }
            
            val_3 = eventId.ToString();
            OneSignal.SendTag(tagName:  "KingsCupEventId", tagValue:  val_3);
            mem2[0] = 1;
        }
        public static void TryUpdateUserTeamBattleEventIdTag(long eventId)
        {
            string val_3;
            var val_4;
            val_3 = eventId;
            val_4 = 17398;
            val_4 = 41188;
            if(val_3 == 0)
            {
                    return;
            }
            
            if(Royal.Infrastructure.Services.Notification.GameNotificationService.IsOneSignalInitialized() == false)
            {
                    return;
            }
            
            val_3 = eventId.ToString();
            OneSignal.SendTag(tagName:  "TeamBattleEventId", tagValue:  val_3);
            mem2[0] = 1;
        }
        public static void TryUpdateUserPropellerMadnessEventIdTag(long eventId)
        {
            string val_3;
            var val_4;
            val_3 = eventId;
            val_4 = 17396;
            val_4 = 41188;
            if(val_3 == 0)
            {
                    return;
            }
            
            if(Royal.Infrastructure.Services.Notification.GameNotificationService.IsOneSignalInitialized() == false)
            {
                    return;
            }
            
            val_3 = eventId.ToString();
            OneSignal.SendTag(tagName:  "PropellerMadnessEventId", tagValue:  val_3);
            mem2[0] = 1;
        }
        public static void TryUpdateUserLadderOfferEventIdTag(long eventId)
        {
            string val_3;
            var val_4;
            val_3 = eventId;
            val_4 = 17395;
            val_4 = 41188;
            if(val_3 == 0)
            {
                    return;
            }
            
            if(Royal.Infrastructure.Services.Notification.GameNotificationService.IsOneSignalInitialized() == false)
            {
                    return;
            }
            
            val_3 = eventId.ToString();
            OneSignal.SendTag(tagName:  "LadderOfferEventId", tagValue:  val_3);
            mem2[0] = 1;
        }
        public static void TryUpdateUserRoyalPassEventIdTag(long eventId)
        {
            string val_3;
            var val_4;
            val_3 = eventId;
            val_4 = 17397;
            val_4 = 41188;
            if(val_3 == 0)
            {
                    return;
            }
            
            if(Royal.Infrastructure.Services.Notification.GameNotificationService.IsOneSignalInitialized() == false)
            {
                    return;
            }
            
            val_3 = eventId.ToString();
            OneSignal.SendTag(tagName:  "RoyalPassEventId", tagValue:  val_3);
            mem2[0] = 1;
        }
        private void HandleNotificationReceived(OSNotification notification)
        {
        
        }
        private static void IdsAvailable(string playerID, string pushToken)
        {
            if((System.String.IsNullOrEmpty(value:  pushToken)) != false)
            {
                    return;
            }
            
            com.adjust.sdk.Adjust.setDeviceToken(deviceToken:  pushToken);
            Royal.Scenes.Home.Context.HomeContext.Get<Royal.Infrastructure.Services.Helpshift.HelpshiftManager>(id:  1).RegisterPushToken(playerId:  playerID, token:  pushToken);
        }
        public GameNotificationService()
        {
            this.platform = new Royal.Infrastructure.Services.Notification.AndroidGameNotificationPlatform();
        }
        private static void HandleNotificationOpened(OSNotificationOpenedResult result)
        {
        
        }
        private void ScheduleNotification(Royal.Infrastructure.Services.Notification.GameNotification notification)
        {
            var val_9;
            var val_10;
            if((System.String.IsNullOrEmpty(value:  notification.<Title>k__BackingField)) != false)
            {
                    if((System.String.IsNullOrEmpty(value:  notification.<Text>k__BackingField)) != false)
            {
                    val_9 = public static T[] System.Array::Empty<System.Object>();
                val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  13, log:  "Scheduled notification title and text is empty", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                return;
            }
            
            }
            
            bool val_3 = Royal.Infrastructure.Services.Notification.GameNotificationService.IsFireTimePermitted(fireTime:  new System.DateTime() {dateData = notification.<FireTime>k__BackingField.dateData});
            val_9 = val_3;
            if(val_3 != true)
            {
                    System.DateTime val_4 = notification.<FireTime>k__BackingField.dateData.Date;
                System.DateTime val_5 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_4.dateData}, t:  new System.TimeSpan());
                notification.<FireTime>k__BackingField.dateData = val_5.dateData;
            }
            
            var val_8 = 0;
            if(mem[1152921505134145536] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    Royal.Infrastructure.Services.Notification.IGameNotificationPlatform val_6 = 1152921505134108672 + ((mem[1152921505134145544]) << 4);
            }
            
            this.platform.ScheduleNotification(notification:  new Royal.Infrastructure.Services.Notification.GameNotification() {<Title>k__BackingField = notification.<Title>k__BackingField, <Text>k__BackingField = notification.<Title>k__BackingField, <FireTime>k__BackingField = new System.DateTime() {dateData = notification.<FireTime>k__BackingField.dateData}});
            object[] val_7 = new object[2];
            val_7[0] = notification.<Title>k__BackingField;
            object val_9 = ~val_9;
            val_9 = val_9 & 1;
            val_7[1] = val_9;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Scheduled notification {0}, postponed: {1}", values:  val_7);
        }
        public void CancelNotification(int notificationId)
        {
            var val_2 = 0;
            if(mem[1152921505134145536] != null)
            {
                    val_2 = val_2 + 1;
            }
            else
            {
                    var val_3 = mem[1152921505134145544];
                val_3 = val_3 + 1;
                Royal.Infrastructure.Services.Notification.IGameNotificationPlatform val_1 = 1152921505134108672 + val_3;
            }
            
            this.platform.CancelNotification(notificationId:  notificationId);
        }
        public void DismissNotification(int notificationId)
        {
            var val_2 = 0;
            if(mem[1152921505134145536] != null)
            {
                    val_2 = val_2 + 1;
            }
            else
            {
                    var val_3 = mem[1152921505134145544];
                val_3 = val_3 + 2;
                Royal.Infrastructure.Services.Notification.IGameNotificationPlatform val_1 = 1152921505134108672 + val_3;
            }
            
            this.platform.DismissNotification(notificationId:  notificationId);
        }
        public void CancelAllScheduledNotifications()
        {
            var val_2 = 0;
            if(mem[1152921505134145536] != null)
            {
                    val_2 = val_2 + 1;
            }
            else
            {
                    var val_3 = mem[1152921505134145544];
                val_3 = val_3 + 3;
                Royal.Infrastructure.Services.Notification.IGameNotificationPlatform val_1 = 1152921505134108672 + val_3;
            }
            
            this.platform.CancelAllScheduledNotifications();
        }
        public void DismissAllNotifications()
        {
            var val_2 = 0;
            if(mem[1152921505134145536] != null)
            {
                    val_2 = val_2 + 1;
            }
            else
            {
                    var val_3 = mem[1152921505134145544];
                val_3 = val_3 + 4;
                Royal.Infrastructure.Services.Notification.IGameNotificationPlatform val_1 = 1152921505134108672 + val_3;
            }
            
            this.platform.DismissAllNotifications();
        }
        private void ClearAllNotifications()
        {
            this.notificationsAreScheduled = false;
            var val_3 = 0;
            if(mem[1152921505134145536] != null)
            {
                    val_3 = val_3 + 1;
            }
            else
            {
                    var val_4 = mem[1152921505134145544];
                val_4 = val_4 + 3;
                Royal.Infrastructure.Services.Notification.IGameNotificationPlatform val_1 = 1152921505134108672 + val_4;
            }
            
            this.platform.CancelAllScheduledNotifications();
            var val_5 = 0;
            if(mem[1152921505134145536] != null)
            {
                    val_5 = val_5 + 1;
            }
            else
            {
                    var val_6 = mem[1152921505134145544];
                val_6 = val_6 + 4;
                Royal.Infrastructure.Services.Notification.IGameNotificationPlatform val_2 = 1152921505134108672 + val_6;
            }
            
            this.platform.DismissAllNotifications();
        }
        private void OnApplicationQuit()
        {
            if(this.notificationsAreScheduled != false)
            {
                    object[] val_1 = new object[1];
                val_1[0] = this.notificationsAreScheduled;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "OnApplicationQuit notificationsAreScheduled: {0}", values:  val_1);
                return;
            }
            
            this.OnApplicationBackground();
        }
        private void OnApplicationPause()
        {
            if(this.notificationsAreScheduled != false)
            {
                    object[] val_1 = new object[1];
                val_1[0] = this.notificationsAreScheduled;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "OnApplicationPause notificationsAreScheduled: {0}", values:  val_1);
                return;
            }
            
            this.OnApplicationBackground();
        }
        private void OnApplicationResume()
        {
            this.ClearAllNotifications();
            this.InvokeDeviceNotificationSettingsChangeIfNeeded();
        }
        private void InvokeDeviceNotificationSettingsChangeIfNeeded()
        {
            bool val_1 = this.IsNotificationEnabledInDeviceSettings();
            var val_2 = (this.isNotificationEnabledInDeviceSettings == true) ? 1 : 0;
            val_2 = val_1 ^ val_2;
            if(val_2 == false)
            {
                    return;
            }
            
            this.isNotificationEnabledInDeviceSettings = val_1;
            if(this.OnDeviceNotificationSettingsChange == null)
            {
                    return;
            }
            
            this.OnDeviceNotificationSettingsChange.Invoke();
        }
        private void OnApplicationBackground()
        {
            if(this.isNotificationEnabledInGameSettings == false)
            {
                    return;
            }
            
            if(this.isNotificationEnabledInDeviceSettings == false)
            {
                    return;
            }
            
            this.notificationsAreScheduled = true;
            this.SetUpLifeNotifications();
            this.SetUpInboxNotifications();
            this.SetUpTeamBattleNotifications(didSetTeamBattleEndNotif: ref  false, didDelayTeamBattle1DayNotif: ref  false);
            this.SetUpKingsCupNotifications(didSetTeamBattleEndNotif:  false);
            this.SetUpMadnessNotifications(didDelayTeamBattle1DayNotification:  false);
            this.SetUpDailyNotifications();
            this.SetUpLadderOfferNotifications(didDelayTeamBattle1DayNotification:  false);
            this.SetUpRoyalPassNotifications();
        }
        private void SetUpLifeNotifications()
        {
            Royal.Player.Context.Units.LifeHelper val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LifeHelper>(id:  3);
            if(val_1.HasUnlimitedLives() == true)
            {
                    return;
            }
            
            if(val_1.GetLives() >= Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave)
            {
                    return;
            }
            
            if(val_1.GetLives() == 0)
            {
                    System.DateTime val_6 = System.DateTime.UtcNow;
                System.DateTime val_8 = val_6.dateData.AddSeconds(value:  (double)val_1.RemainingSecondsToNextLife());
                System.DateTime val_9 = val_8.dateData.ToLocalTime();
                if((Royal.Infrastructure.Services.Notification.GameNotificationService.IsFireTimePermitted(fireTime:  new System.DateTime() {dateData = val_9.dateData})) != false)
            {
                    this.ScheduleNotification(notification:  new Royal.Infrastructure.Services.Notification.GameNotification() {<Text>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "OneLifeNotification", ignoreArabicFix:  true), <FireTime>k__BackingField = new System.DateTime() {dateData = val_9.dateData}});
            }
            
            }
            
            System.DateTime val_13 = Royal.Infrastructure.Utils.Time.TimeUtil.MsToDateTime(ms:  Royal.Player.Context.Data.Persistent.BasicUserData.__il2cppRuntimeField_byval_arg);
            System.DateTime val_14 = val_13.dateData.ToLocalTime();
            this.ScheduleNotification(notification:  new Royal.Infrastructure.Services.Notification.GameNotification() {<Text>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "FullLifeNotification", ignoreArabicFix:  true), <FireTime>k__BackingField = new System.DateTime() {dateData = val_14.dateData}});
        }
        private void SetUpInboxNotifications()
        {
            Royal.Player.Context.Units.SocialManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            if(Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs() >= (val_1.<NextAskLifeTimeMs>k__BackingField))
            {
                    return;
            }
            
            System.DateTime val_4 = Royal.Infrastructure.Utils.Time.TimeUtil.MsToDateTime(ms:  val_1.<NextAskLifeTimeMs>k__BackingField);
            System.DateTime val_5 = val_4.dateData.ToLocalTime();
            this.ScheduleNotification(notification:  new Royal.Infrastructure.Services.Notification.GameNotification() {<Text>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "AskLifeNotification", ignoreArabicFix:  true), <FireTime>k__BackingField = new System.DateTime() {dateData = val_5.dateData}});
        }
        private void SetUpKingsCupNotifications(bool didSetTeamBattleEndNotif)
        {
            long val_18;
            Royal.Player.Context.Units.KingsCupManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7);
            val_18 = val_1;
            if(val_1.IsInAGroup == false)
            {
                    return;
            }
            
            if(val_18.IsRemainingTimeFinished == true)
            {
                    return;
            }
            
            val_18 = val_18.RemainingTimeInMs;
            if((Royal.Infrastructure.Utils.Time.TimeUtil.ConvertMsToMinutes(milliseconds:  val_18)) >= 60)
            {
                    System.DateTime val_6 = System.DateTime.UtcNow;
                System.DateTime val_7 = val_6.dateData.AddMilliseconds(value:  (double)val_18);
                System.DateTime val_8 = val_7.dateData.AddMinutes(value:  -60);
                System.DateTime val_9 = val_8.dateData.ToLocalTime();
                if((Royal.Infrastructure.Services.Notification.GameNotificationService.IsFireTimePermitted(fireTime:  new System.DateTime() {dateData = val_9.dateData})) != false)
            {
                    this.ScheduleNotification(notification:  new Royal.Infrastructure.Services.Notification.GameNotification() {<Title>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "KingsCup1HourNotificationTitle", ignoreArabicFix:  true), <Text>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "KingsCup1HourNotificationBody", ignoreArabicFix:  true), <FireTime>k__BackingField = new System.DateTime() {dateData = val_9.dateData}});
            }
            
            }
            
            if(didSetTeamBattleEndNotif == true)
            {
                    return;
            }
            
            System.DateTime val_14 = System.DateTime.UtcNow;
            System.DateTime val_15 = val_14.dateData.AddMilliseconds(value:  (double)val_18);
            System.DateTime val_16 = val_15.dateData.ToLocalTime();
            val_18 = val_16.dateData;
            this.ScheduleNotification(notification:  new Royal.Infrastructure.Services.Notification.GameNotification() {<Title>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "KingsCupEndNotificationTitle", ignoreArabicFix:  true), <Text>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "KingsCupEndNotificationBody", ignoreArabicFix:  true), <FireTime>k__BackingField = new System.DateTime() {dateData = val_18}});
        }
        private void SetUpTeamBattleNotifications(ref bool didSetTeamBattleEndNotif, ref bool didDelayTeamBattle1DayNotif)
        {
            ulong val_25;
            Royal.Player.Context.Units.TeamBattleManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9);
            val_25 = val_1;
            if(val_1.IsInAGroup == false)
            {
                    return;
            }
            
            if(val_25.IsRemainingTimeFinished == true)
            {
                    return;
            }
            
            if((val_1.myScore & 2147483648) != 0)
            {
                    return;
            }
            
            long val_4 = val_25.RemainingTimeInMs;
            int val_5 = Royal.Infrastructure.Utils.Time.TimeUtil.ConvertMsToMinutes(milliseconds:  val_4);
            if(val_5 >= 1440)
            {
                goto label_9;
            }
            
            if(val_5 >= 120)
            {
                goto label_10;
            }
            
            goto label_16;
            label_9:
            System.DateTime val_6 = System.DateTime.UtcNow;
            System.DateTime val_7 = val_6.dateData.AddMilliseconds(value:  (double)val_4);
            System.DateTime val_8 = val_7.dateData.AddMinutes(value:  -1440);
            System.DateTime val_9 = val_8.dateData.ToLocalTime();
            bool val_25 = ~(Royal.Infrastructure.Services.Notification.GameNotificationService.IsFireTimePermitted(fireTime:  new System.DateTime() {dateData = val_9.dateData}));
            val_25 = val_25 & 1;
            didDelayTeamBattle1DayNotif = val_25;
            this.ScheduleNotification(notification:  new Royal.Infrastructure.Services.Notification.GameNotification() {<Title>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "TeamBattle1DayTitle", ignoreArabicFix:  true), <Text>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "TeamBattle1DayText", ignoreArabicFix:  true), <FireTime>k__BackingField = new System.DateTime() {dateData = val_9.dateData}});
            label_10:
            System.DateTime val_13 = System.DateTime.UtcNow;
            System.DateTime val_14 = val_13.dateData.AddMilliseconds(value:  (double)val_4);
            System.DateTime val_15 = val_14.dateData.AddMinutes(value:  -120);
            System.DateTime val_16 = val_15.dateData.ToLocalTime();
            if((Royal.Infrastructure.Services.Notification.GameNotificationService.IsFireTimePermitted(fireTime:  new System.DateTime() {dateData = val_16.dateData})) != false)
            {
                    this.ScheduleNotification(notification:  new Royal.Infrastructure.Services.Notification.GameNotification() {<Title>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "TeamBattle1HourTitle", ignoreArabicFix:  true), <Text>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "TeamBattle1HourText", ignoreArabicFix:  true), <FireTime>k__BackingField = new System.DateTime() {dateData = val_16.dateData}});
            }
            
            label_16:
            didSetTeamBattleEndNotif = true;
            System.DateTime val_21 = System.DateTime.UtcNow;
            System.DateTime val_22 = val_21.dateData.AddMilliseconds(value:  (double)val_4);
            System.DateTime val_23 = val_22.dateData.ToLocalTime();
            val_25 = val_23.dateData;
            this.ScheduleNotification(notification:  new Royal.Infrastructure.Services.Notification.GameNotification() {<Title>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "TeamBattleEndTitle", ignoreArabicFix:  true), <Text>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "TeamBattleEndText", ignoreArabicFix:  true), <FireTime>k__BackingField = new System.DateTime() {dateData = val_25}});
        }
        private void SetUpMadnessNotifications(bool didDelayTeamBattle1DayNotification)
        {
            int val_14;
            var val_15;
            string val_16;
            string val_17;
            int val_18;
            Royal.Player.Context.Units.MadnessManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10);
            val_14 = val_1;
            if(val_1.IsLevelSatisfied != false)
            {
                    val_15 = val_14.IsCompleted();
            }
            else
            {
                    val_15 = 1;
            }
            
            val_15 = val_15 | didDelayTeamBattle1DayNotification;
            if(val_15 == true)
            {
                    return;
            }
            
            long val_5 = val_14.RemainingTimeInMs;
            if((Royal.Infrastructure.Utils.Time.TimeUtil.ConvertMsToMinutes(milliseconds:  val_5)) < 1380)
            {
                    return;
            }
            
            if(val_1.type == 0)
            {
                goto label_10;
            }
            
            if(val_1.type != 3)
            {
                goto label_11;
            }
            
            val_16 = "BookofTreasure1DayText";
            val_17 = "BookofTreasure1DayTitle";
            goto label_12;
            label_10:
            val_16 = "PropellerMadness1DayText";
            val_17 = "PropellerMadness1DayTitle";
            label_12:
            val_14 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_17, ignoreArabicFix:  true);
            val_18 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_16, ignoreArabicFix:  true);
            goto label_13;
            label_11:
            val_18 = System.String.alignConst;
            val_14 = val_18;
            label_13:
            System.DateTime val_9 = System.DateTime.UtcNow;
            System.DateTime val_10 = val_9.dateData.AddMilliseconds(value:  (double)val_5);
            System.DateTime val_11 = val_10.dateData.AddMinutes(value:  -1380);
            System.DateTime val_12 = val_11.dateData.ToLocalTime();
            this.ScheduleNotification(notification:  new Royal.Infrastructure.Services.Notification.GameNotification() {<Title>k__BackingField = val_14, <Text>k__BackingField = val_18, <FireTime>k__BackingField = new System.DateTime() {dateData = val_12.dateData}});
        }
        private void SetUpLadderOfferNotifications(bool didDelayTeamBattle1DayNotification)
        {
            Royal.Player.Context.Units.LadderOfferManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11);
            if(val_1.IsCompleted() == true)
            {
                    return;
            }
            
            if(didDelayTeamBattle1DayNotification == true)
            {
                    return;
            }
            
            long val_3 = val_1.RemainingTimeInMs;
            if((Royal.Infrastructure.Utils.Time.TimeUtil.ConvertMsToMinutes(milliseconds:  val_3)) < 1320)
            {
                    return;
            }
            
            System.DateTime val_6 = System.DateTime.UtcNow;
            System.DateTime val_7 = val_6.dateData.AddMilliseconds(value:  (double)val_3);
            System.DateTime val_8 = val_7.dateData.AddMinutes(value:  -1320);
            System.DateTime val_9 = val_8.dateData.ToLocalTime();
            this.ScheduleNotification(notification:  new Royal.Infrastructure.Services.Notification.GameNotification() {<Title>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "LadderOffer1DayTitle", ignoreArabicFix:  true), <Text>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "LadderOffer1DayText", ignoreArabicFix:  true), <FireTime>k__BackingField = new System.DateTime() {dateData = val_9.dateData}});
        }
        private void SetUpRoyalPassNotifications()
        {
            Royal.Player.Context.Units.RoyalPassManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            if(val_1.IsEventActive == false)
            {
                    return;
            }
            
            long val_3 = val_1.RemainingTimeInMs;
            if((Royal.Infrastructure.Utils.Time.TimeUtil.ConvertMsToMinutes(milliseconds:  val_3)) < 4320)
            {
                    return;
            }
            
            System.DateTime val_6 = System.DateTime.UtcNow;
            System.DateTime val_7 = val_6.dateData.AddMilliseconds(value:  (double)val_3);
            System.DateTime val_8 = val_7.dateData.AddMinutes(value:  -4320);
            System.DateTime val_9 = val_8.dateData.ToLocalTime();
            this.ScheduleNotification(notification:  new Royal.Infrastructure.Services.Notification.GameNotification() {<Title>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "RoyalPass3DayNotificationTitle", ignoreArabicFix:  true), <Text>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "RoyalPass3DayNotificationText", ignoreArabicFix:  true), <FireTime>k__BackingField = new System.DateTime() {dateData = val_9.dateData}});
        }
        private void SetUpDailyNotifications()
        {
            System.DateTime val_2 = System.DateTime.UtcNow;
            System.DateTime val_3 = val_2.dateData.AddDays(value:  1);
            System.DateTime val_4 = val_3.dateData.ToLocalTime();
            this.ScheduleNotification(notification:  new Royal.Infrastructure.Services.Notification.GameNotification() {<Text>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "AfterOneDayNotification", ignoreArabicFix:  true), <FireTime>k__BackingField = new System.DateTime() {dateData = val_4.dateData}});
            System.DateTime val_6 = System.DateTime.UtcNow;
            System.DateTime val_7 = val_6.dateData.AddDays(value:  2);
            System.DateTime val_8 = val_7.dateData.ToLocalTime();
            this.ScheduleNotification(notification:  new Royal.Infrastructure.Services.Notification.GameNotification() {<Text>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "AfterTwoDaysNotification", ignoreArabicFix:  true), <FireTime>k__BackingField = new System.DateTime() {dateData = val_8.dateData}});
            System.DateTime val_10 = System.DateTime.UtcNow;
            System.DateTime val_11 = val_10.dateData.AddDays(value:  3);
            System.DateTime val_12 = val_11.dateData.ToLocalTime();
            this.ScheduleNotification(notification:  new Royal.Infrastructure.Services.Notification.GameNotification() {<Text>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "AfterThreeDaysNotification", ignoreArabicFix:  true), <FireTime>k__BackingField = new System.DateTime() {dateData = val_12.dateData}});
            System.DateTime val_14 = System.DateTime.UtcNow;
            System.DateTime val_15 = val_14.dateData.AddDays(value:  7);
            System.DateTime val_16 = val_15.dateData.ToLocalTime();
            this.ScheduleNotification(notification:  new Royal.Infrastructure.Services.Notification.GameNotification() {<Text>k__BackingField = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "AfterSevenDaysNotification", ignoreArabicFix:  true), <FireTime>k__BackingField = new System.DateTime() {dateData = val_16.dateData}});
        }
        private static bool IsFireTimePermitted(System.DateTime fireTime)
        {
            System.DateTime val_1 = System.DateTime.Now;
            if(val_1.dateData.Hour < 7)
            {
                    return (bool)(fireTime.dateData.Hour > 9) ? 1 : 0;
            }
            
            System.DateTime val_3 = System.DateTime.Now;
            if(val_3.dateData.Hour <= 9)
            {
                    if(fireTime.dateData.Hour > 6)
            {
                    return (bool)(fireTime.dateData.Hour > 9) ? 1 : 0;
            }
            
            }
            
            return (bool)(fireTime.dateData.Hour > 9) ? 1 : 0;
        }
        public bool IsNotificationEnabled()
        {
            if(this.isNotificationEnabledInGameSettings == false)
            {
                    return false;
            }
            
            return (bool)(this.isNotificationEnabledInDeviceSettings == true) ? 1 : 0;
        }
        public bool IsNotificationEnabledInDeviceSettings()
        {
            var val_4;
            if(Royal.Infrastructure.Services.Notification.GameNotificationService.IsOneSignalInitialized() != false)
            {
                    OSPermissionSubscriptionState val_2 = OneSignal.GetPermissionSubscriptionState();
                var val_3 = (val_2.permissionStatus.status == 2) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public void DisableNotificationInGameSettings()
        {
            this.ClearAllNotifications();
            if(Royal.Infrastructure.Services.Notification.GameNotificationService.IsOneSignalInitialized() != false)
            {
                    OneSignal.ClearOneSignalNotifications();
                OneSignal.SetSubscription(enable:  false);
            }
            
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.SetInt(db:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService, key:  "Notification", value:  0, synced:  false);
            this.isNotificationEnabledInGameSettings = false;
        }
        public void EnableNotificationInGameSettings()
        {
            if(Royal.Infrastructure.Services.Notification.GameNotificationService.IsOneSignalInitialized() != false)
            {
                    OneSignal.SetSubscription(enable:  true);
            }
            
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.KeyValueTable.SetInt(db:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DatabaseService, key:  "Notification", value:  1, synced:  false);
            this.isNotificationEnabledInGameSettings = true;
        }
    
    }

}
