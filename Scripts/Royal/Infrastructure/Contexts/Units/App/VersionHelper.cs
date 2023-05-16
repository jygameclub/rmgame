using UnityEngine;

namespace Royal.Infrastructure.Contexts.Units.App
{
    public class VersionHelper
    {
        // Fields
        public Royal.Infrastructure.Contexts.Units.App.VersionState versionState;
        public int currentVersion;
        public int oldVersion;
        private int forceVersion;
        private bool forceAlertActive;
        
        // Methods
        public void UpdateVersion()
        {
            int val_8;
            Royal.Infrastructure.Contexts.Units.App.VersionState val_9;
            this.forceVersion = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetInt(key:  "ForceVersion", defaultValue:  0);
            this.oldVersion = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetInt(key:  "Version", defaultValue:  0);
            bool val_5 = System.Int32.TryParse(s:  UnityEngine.Application.version, result: out  this.currentVersion);
            if(this.oldVersion == 0)
            {
                goto label_1;
            }
            
            val_8 = mem[this.currentVersion];
            val_8 = this.currentVersion;
            if(this.oldVersion != val_8)
            {
                goto label_2;
            }
            
            val_9 = this;
            this.versionState = 0;
            val_8 = this.oldVersion;
            goto label_5;
            label_1:
            val_9 = this;
            this.versionState = 1;
            val_8 = this.currentVersion;
            goto label_5;
            label_2:
            val_9 = this.versionState;
            if(val_8 > this.oldVersion)
            {
                    val_9 = 2;
            }
            
            label_5:
            bool val_6 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetInt(key:  "Version", value:  val_8);
            object[] val_7 = new object[4];
            val_7[0] = val_9;
            val_7[1] = this.oldVersion;
            val_7[2] = this.currentVersion;
            val_7[3] = this.forceVersion;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  1, log:  "Version: {0} / {1} -> {2} / {3}", values:  val_7);
        }
        public void UpdateForceVersion(int version)
        {
            if(this.forceVersion == version)
            {
                    return;
            }
            
            this.forceVersion = version;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetInt(key:  "ForceVersion", value:  version);
        }
        public void CheckForceUpdate()
        {
            if(this.currentVersion < this.forceVersion)
            {
                    if(this.forceAlertActive != true)
            {
                    Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
                val_1.disabler.DisableTouch();
                Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameTouchListener>(id:  0).DisableTouch();
            }
            
                this.forceAlertActive = true;
                object[] val_3 = new object[1];
                val_3[0] = this.forceVersion;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  0, log:  "Force update version: {0}", values:  val_3);
                Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19).ShowAlertMessage(show:  true, title:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "ForceUpdateTitle"), message:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "ForceUpdateMessage"), action:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "ForceUpdateAction"));
                return;
            }
            
            this.TryCloseForceAlert();
        }
        public void TryCloseForceAlert()
        {
            if(this.forceAlertActive == false)
            {
                    return;
            }
            
            this.forceAlertActive = false;
            object[] val_1 = new object[1];
            val_1[0] = this.forceVersion;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  0, log:  "Force update version: {0}", values:  val_1);
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            val_2.disabler.EnableTouch();
            Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameTouchListener>(id:  0).EnableTouch();
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19).ShowAlertMessage(show:  false, title:  0, message:  0, action:  0);
        }
        public void Migrate()
        {
            var val_7;
            int val_8;
            val_7 = this;
            if(this.versionState != 2)
            {
                    return;
            }
            
            Royal.Infrastructure.Services.Remote.RemoteLevels.RemoveAll();
            if(this.oldVersion <= 3005)
            {
                    bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DeleteKey(key:  "Leaderboard");
            }
            
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsAndroid == false)
            {
                goto label_5;
            }
            
            val_8 = this.oldVersion;
            if((val_8 - 3488) > 298)
            {
                goto label_6;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Notification.GameNotificationService>(id:  18).RequestAuthorization();
            label_5:
            val_8 = this.oldVersion;
            label_6:
            if(val_8 <= 4229)
            {
                    bool val_5 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.DeleteKey(key:  "LWM");
                val_8 = this.oldVersion;
            }
            
            if(val_8 > 4402)
            {
                    return;
            }
            
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<IsTemp>k__BackingField) != false)
            {
                    return;
            }
            
            Royal.Infrastructure.Services.Native.NativeService val_6 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            val_6.backupManager.UpdateUserId(force:  false);
        }
        public VersionHelper()
        {
        
        }
    
    }

}
