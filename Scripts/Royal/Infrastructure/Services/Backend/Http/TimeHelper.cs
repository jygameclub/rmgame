using UnityEngine;

namespace Royal.Infrastructure.Services.Backend.Http
{
    public class TimeHelper : IContextUnit
    {
        // Fields
        private const int TimeBuffer = 60000;
        private bool <IsTimeValidatedByBackend>k__BackingField;
        private bool <IsOfflineClientTimeTakenBack>k__BackingField;
        private bool <IsLifeHackDetected>k__BackingField;
        private Royal.Infrastructure.Services.Backend.Http.BackendHttpService backendHttpService;
        private Royal.Infrastructure.Services.Login.LoginService loginService;
        private Royal.Infrastructure.Services.Native.NativeService nativeService;
        private Royal.Player.Context.Units.LifeHelper lifeHelper;
        private long lastClientTime;
        private long serverClientTimeDiff;
        private int currentEarnedLifeCount;
        private int lifeHackDetectedSyncId;
        private int lifeHackDetectedLevel;
        
        // Properties
        public bool IsTimeValidatedByBackend { get; set; }
        public bool IsOfflineClientTimeTakenBack { get; set; }
        public bool IsLifeHackDetected { get; set; }
        public int Id { get; }
        
        // Methods
        public bool get_IsTimeValidatedByBackend()
        {
            return (bool)this.<IsTimeValidatedByBackend>k__BackingField;
        }
        private void set_IsTimeValidatedByBackend(bool value)
        {
            this.<IsTimeValidatedByBackend>k__BackingField = value;
        }
        public bool get_IsOfflineClientTimeTakenBack()
        {
            return (bool)this.<IsOfflineClientTimeTakenBack>k__BackingField;
        }
        private void set_IsOfflineClientTimeTakenBack(bool value)
        {
            this.<IsOfflineClientTimeTakenBack>k__BackingField = value;
        }
        public bool get_IsLifeHackDetected()
        {
            return (bool)this.<IsLifeHackDetected>k__BackingField;
        }
        private void set_IsLifeHackDetected(bool value)
        {
            this.<IsLifeHackDetected>k__BackingField = value;
        }
        public int get_Id()
        {
            return 14;
        }
        public void Bind()
        {
            this.serverClientTimeDiff = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetLong(key:  "STD", defaultValue:  0);
            object[] val_2 = new object[1];
            val_2[0] = this.serverClientTimeDiff;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Server-Client Time Diff: {0}", values:  val_2);
            this.lastClientTime = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetLong(key:  "LCT", defaultValue:  0);
            this.backendHttpService = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7);
            this.loginService = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Login.LoginService>(id:  20);
            this.nativeService = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            this.lifeHelper = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LifeHelper>(id:  3);
            Royal.Infrastructure.Contexts.Units.App.AppManager val_8 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            System.Action val_9 = static_value_02DC1B30;
            val_9 = new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Backend.Http.TimeHelper::OnAppStart());
            val_8.add_OnApplicationStart(value:  val_9);
            System.Action val_10 = static_value_02DC1B30;
            val_10 = new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Backend.Http.TimeHelper::OnAppPause());
            val_8.add_OnApplicationPause(value:  val_10);
            System.Action val_11 = static_value_02DC1B30;
            val_11 = new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Backend.Http.TimeHelper::OnAppResume());
            val_8.add_OnApplicationResume(value:  val_11);
            Royal.Infrastructure.Utils.Time.TimeUtil.CacheLocalizations();
        }
        private void OnAppStart()
        {
            this.CheckClientTime();
            this.SendPing();
        }
        private void OnAppResume()
        {
            this.CheckClientTime();
            this.SendPing();
        }
        private void CheckClientTime()
        {
            var val_9;
            this.<IsOfflineClientTimeTakenBack>k__BackingField = false;
            if(this.lastClientTime > (Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs() + 60000))
            {
                    this.<IsOfflineClientTimeTakenBack>k__BackingField = true;
                val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Client time is taken back", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                return;
            }
            
            this.currentEarnedLifeCount = UnityEngine.Mathf.Max(a:  0, b:  this.lifeHelper.GetLives() - (Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetInt(key:  "LCP", defaultValue:  Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave)));
            object[] val_8 = new object[1];
            val_8[0] = this.currentEarnedLifeCount;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "CurrentEarnedLifeCount = {0}", values:  val_8);
        }
        private void OnAppPause()
        {
            var val_23;
            long val_24;
            string val_25;
            var val_26;
            object val_27;
            System.Object[] val_28;
            long val_29;
            if((this.<IsTimeValidatedByBackend>k__BackingField) != false)
            {
                    long val_1 = this.CurrentServerTimeInMs();
                val_23 = this;
                val_24 = 0;
                if(this.lifeHelper.IsFull() != true)
            {
                    val_24 = this.lifeHelper.PassedTimeMsForNextLife();
            }
            
                long val_5 = (val_1 - val_24) + 59999;
                bool val_6 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetLong(key:  "LST", value:  val_5);
                bool val_7 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.DeleteKey(key:  "OULT");
                object[] val_8 = new object[3];
                val_8[0] = val_24;
                val_8[1] = val_1;
                val_8[2] = val_5;
                val_25 = "On pause (online) {0} - {1} - {2}";
                val_26 = 9;
                val_27 = this;
                val_28 = val_8;
            }
            else
            {
                    val_23 = this;
                val_29 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetLong(key:  "LST", defaultValue:  0);
                long val_23 = (long)Royal.Infrastructure.Contexts.Units.App.AppManager.<CurrentSessionTime>k__BackingField;
                val_23 = val_23 * 1000;
                float val_10 = val_23 / this.lifeHelper.requiredTimeInMsToFillOneLife;
                if(val_10 >= (1.401298E-45f))
            {
                    var val_24 = 59999;
                val_24 = this.lifeHelper.requiredTimeInMsToFillOneLife + val_24;
                val_29 = val_29 + (val_10 * val_24);
                bool val_11 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetLong(key:  "LST", value:  val_29);
            }
            
                long val_12 = this.lifeHelper.RemainingMsToEndUnlimitedTimes();
                bool val_13 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetLong(key:  "OULT", value:  val_12);
                object[] val_14 = new object[3];
                val_14[0] = val_10;
                val_14[1] = val_29;
                val_14[2] = val_12;
                val_25 = "On pause (offline) {0} - {1} - {2}";
                val_26 = 9;
                val_27 = this;
                val_28 = val_14;
            }
            
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  val_25, values:  val_14);
            int val_15 = this.lifeHelper.GetLives();
            bool val_16 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetInt(key:  "LCP", value:  val_15);
            int val_18 = (Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetInt(key:  "ELC", defaultValue:  0)) + this.currentEarnedLifeCount;
            bool val_19 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetInt(key:  "ELC", value:  val_18);
            object[] val_20 = new object[2];
            val_20[0] = val_15;
            val_20[1] = val_18;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "CurrentLifeCount = {0}, TotalEarnedLifeCount = {1}", values:  val_20);
            this.<IsTimeValidatedByBackend>k__BackingField = false;
            if((this.<IsOfflineClientTimeTakenBack>k__BackingField) == true)
            {
                    return;
            }
            
            long val_21 = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs();
            this.lastClientTime = val_21;
            bool val_22 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetLong(key:  "LCT", value:  val_21);
        }
        public void SendPing()
        {
            var val_4;
            System.Object[] val_5;
            string val_6;
            var val_7;
            var val_8;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<IsTemp>k__BackingField) == false)
            {
                goto label_3;
            }
            
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184;
            val_6 = "Don\'t send ping for temp user";
            goto label_19;
            label_3:
            if(this.loginService.ConnectionInProgress == false)
            {
                goto label_12;
            }
            
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184;
            val_6 = "Don\'t send ping when login is in progress";
            goto label_19;
            label_12:
            if(this.nativeService.purchaseManager.purchaseInProgress == false)
            {
                goto label_22;
            }
            
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184;
            val_6 = "Don\'t send ping when a purchase is in progress";
            label_19:
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  val_6, values:  val_5);
            return;
            label_22:
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_2 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_2.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.PingHttpCommand());
            this.backendHttpService.SendImmediately(commandsToSend:  val_2, timeOut:  10f);
        }
        public bool UpdateTime(long serverTime)
        {
            long val_13;
            var val_14;
            var val_15;
            long val_13 = serverTime;
            if(((this.<IsLifeHackDetected>k__BackingField) != true) && ((this.<IsTimeValidatedByBackend>k__BackingField) != true))
            {
                    if((this.IsThereLifeHack(serverTime:  val_13)) != false)
            {
                    val_14 = 0;
                return (bool)val_14;
            }
            
            }
            
            if((this.<IsOfflineClientTimeTakenBack>k__BackingField) != false)
            {
                    if((Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetLong(key:  "OULT", defaultValue:  0)) >= 1)
            {
                    val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Reset unlimited life because time is taken back.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                UpdateUnlimitedLivesEndTimeInMs(newUnlimitedLivesEndTimeInMs:  1);
            }
            
                ResetTimes();
            }
            
            this.<IsTimeValidatedByBackend>k__BackingField = true;
            this.<IsOfflineClientTimeTakenBack>k__BackingField = false;
            val_13 = this.serverClientTimeDiff;
            val_13 = val_13 - Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs();
            if((System.Math.Abs((float)val_13 - val_13)) >= 0)
            {
                    this.serverClientTimeDiff = val_13;
                bool val_5 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetLong(key:  "STD", value:  val_13);
                object[] val_6 = new object[1];
                val_6[0] = this.serverClientTimeDiff;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "New Server-Client Time Diff: {0}", values:  val_6);
                int val_16 = this.lifeHelper.GetLives();
                var val_15 = (long)Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave - val_16;
                val_15 = this.CurrentServerTimeInMs() + (this.lifeHelper.requiredTimeInMsToFillOneLife * val_15);
                val_16 = val_15 - this.lifeHelper.PassedTimeMsForNextLife();
                UpdateFullLivesTimeInMs(newFullLivesTimeInMs:  val_16);
                object[] val_12 = new object[1];
                val_13 = val_16;
                val_12[0] = val_13;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Update FullLives Time = {0}", values:  val_12);
            }
            
            val_14 = 1;
            return (bool)val_14;
        }
        public long CurrentServerTimeInMs()
        {
            long val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs();
            val_1 = this.serverClientTimeDiff + val_1;
            return (long)val_1;
        }
        public long CurrentServerTimeInSeconds()
        {
            long val_1 = this.CurrentServerTimeInMs();
            return 18446744073709551;
        }
        private bool IsThereLifeHack(long serverTime)
        {
            int val_13;
            object val_14;
            var val_15;
            val_13 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetInt(key:  "ELC", defaultValue:  0);
            object[] val_2 = new object[1];
            val_14 = val_13;
            val_2[0] = val_14;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Previous earned life count = {0}", values:  val_2);
            if(val_13 > 0)
            {
                    long val_3 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetLong(key:  "LST", defaultValue:  0);
                object[] val_4 = new object[1];
                val_14 = val_4;
                val_14[0] = val_3;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Last server time = {0}", values:  val_4);
                if(val_3 > 59999)
            {
                    object[] val_5 = new object[3];
                val_5[0] = serverTime;
                val_5[1] = val_3;
                long val_6 = serverTime - val_3;
                val_5[2] = val_6;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Server time passed: {0} - {1} = {2}", values:  val_5);
                val_6 = (val_6 + 300000) / this.lifeHelper.requiredTimeInMsToFillOneLife;
                object[] val_8 = new object[2];
                val_8[0] = val_6;
                val_14 = this.currentEarnedLifeCount + val_13;
                val_13 = val_14;
                val_8[1] = val_13;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Life counts = {0} / {1}", values:  val_8);
                if(val_6 < (val_14 << ))
            {
                    object[] val_11 = new object[1];
                val_13 = serverTime - Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs();
                val_11[0] = val_13;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "LifeHack Server-Client Time Diff: {0}", values:  val_11);
                this.LifeHackDetected();
                val_15 = 1;
                return (bool)val_15;
            }
            
            }
            
            }
            
            this.ResetLifeHackValues();
            val_15 = 0;
            return (bool)val_15;
        }
        private void LifeHackDetected()
        {
            var val_1;
            var val_2;
            this.<IsLifeHackDetected>k__BackingField = true;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  9, log:  "LifeHack is detected!!! Force refresh progress!!!", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            val_2 = -1152921509027013200;
            this.lifeHackDetectedLevel = typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14;
            this.lifeHackDetectedSyncId = Royal.Player.Context.Data.Persistent.BasicUserData.__il2cppRuntimeField_name;
            UpdateSyncId(newSyncId:  0);
            this.SendPing();
        }
        public void ResetLifeHackValues()
        {
            var val_5;
            this.currentEarnedLifeCount = 0;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetLong(key:  "LST", value:  0);
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetInt(key:  "ELC", value:  0);
            bool val_4 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetInt(key:  "LCP", value:  Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave);
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Reset LifeHack values.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void ShowLifeHackDialog()
        {
            if((this.<IsLifeHackDetected>k__BackingField) == false)
            {
                    return;
            }
            
            this.ResetLifeHackValues();
            this.<IsLifeHackDetected>k__BackingField = false;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Life.ShowLifeHackDialogAction(hackLevel:  this.lifeHackDetectedLevel));
            this.lifeHackDetectedLevel = 0;
        }
        public void LifeHackControlEnabledByBackend(bool enabled)
        {
            var val_1;
            if(enabled == true)
            {
                    return;
            }
            
            if((this.<IsLifeHackDetected>k__BackingField) == false)
            {
                    return;
            }
            
            this.ResetLifeHackValues();
            this.<IsLifeHackDetected>k__BackingField = false;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "LifeHack check is disabled by backend", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            UpdateSyncId(newSyncId:  this.lifeHackDetectedSyncId);
        }
        public bool IsLevelIncreased(int serverLevel, int serverLeagueLevel)
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = serverLevel;
            if(this.lifeHackDetectedLevel >= 1)
            {
                    if(this.lifeHackDetectedLevel > val_1)
            {
                goto label_2;
            }
            
            }
            
            if(((this.lifeHackDetectedLevel < (-serverLeagueLevel)) && (serverLeagueLevel >= 1)) && ((this.lifeHackDetectedLevel & 2147483648) != 0))
            {
                    label_2:
                val_2 = 1;
                return (bool)val_2;
            }
            
            this.ResetLifeHackValues();
            this.<IsLifeHackDetected>k__BackingField = false;
            UpdateSyncId(newSyncId:  this.lifeHackDetectedSyncId);
            val_1 = public static T[] System.Array::Empty<System.Object>();
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "LifeHack cancelled because level is not increased", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            val_2 = 0;
            return (bool)val_2;
        }
        public static string GetTimeZoneInNumberRepresentation()
        {
            string val_5;
            System.TimeZoneInfo val_1 = System.TimeZoneInfo.Local;
            int val_2 = val_1.baseUtcOffset.Hours;
            val_5 = val_2.ToString(format:  "D2");
            if(val_2 < 1)
            {
                    return (string)val_5;
            }
            
            val_5 = "+"("+") + val_5;
            return (string)val_5;
        }
        public TimeHelper()
        {
        
        }
    
    }

}
