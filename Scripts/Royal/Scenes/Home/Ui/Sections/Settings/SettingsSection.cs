using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Settings
{
    public class SettingsSection : Section
    {
        // Fields
        public UnityEngine.Transform center;
        public Royal.Scenes.Home.Ui.Sections.Settings.SocialSettings socialSettings;
        public Royal.Scenes.Home.Ui.Sections.Settings.UiToggleSwitch musicToggle;
        public Royal.Scenes.Home.Ui.Sections.Settings.UiToggleSwitch sfxToggle;
        public Royal.Scenes.Home.Ui.Sections.Settings.UiToggleSwitch hintToggle;
        public Royal.Scenes.Home.Ui.Sections.Settings.UiToggleSwitch notificationToggle;
        public UnityEngine.GameObject buttonBlock;
        public TMPro.TextMeshPro facebookButtonText;
        public UnityEngine.GameObject appleButton;
        public TMPro.TextMeshPro appleButtonText;
        public UnityEngine.GameObject supportNotification;
        public UnityEngine.GameObject settingsNotification;
        public TMPro.TextMeshPro versionText;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Scenes.Game.Levels.Units.MatchHint.HintManager hintManager;
        private Royal.Infrastructure.Services.Notification.GameNotificationService gameNotificationService;
        private Royal.Infrastructure.Services.Login.LoginService loginService;
        private Royal.Infrastructure.Services.Helpshift.HelpshiftManager helpshiftManager;
        private int versionTextCounter;
        private bool notificationToggleTriggeredInternally;
        
        // Methods
        public void Awake()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.hintManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MatchHint.HintManager>(contextId:  16);
            this.gameNotificationService = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Notification.GameNotificationService>(id:  18);
            this.loginService = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Login.LoginService>(id:  20);
            this.helpshiftManager = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Infrastructure.Services.Helpshift.HelpshiftManager>(id:  1);
            this.musicToggle.Toggle(enable:  this.audioManager.IsMusicActive());
            this.sfxToggle.Toggle(enable:  this.audioManager.IsSfxActive());
            this.hintToggle.Toggle(enable:  this.hintManager.IsHintEnabled());
            this.notificationToggle.Toggle(enable:  this.gameNotificationService.IsNotificationEnabled());
            this.musicToggle.add_OnToggleChange(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Settings.SettingsSection::OnMusicToggle(bool active)));
            this.sfxToggle.add_OnToggleChange(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Settings.SettingsSection::OnSfxToggle(bool active)));
            this.hintToggle.add_OnToggleChange(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Settings.SettingsSection::OnHintToggle(bool active)));
            this.notificationToggle.add_OnToggleChange(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Settings.SettingsSection::OnNotificationToggle(bool active)));
            this.gameNotificationService.add_OnDeviceNotificationSettingsChange(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Settings.SettingsSection::OnDeviceNotificationSettingsChange()));
            this.loginService.add_OnLoginChange(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Settings.SettingsSection::OnLoginChange()));
            this.InitForAppleLogin();
            this.PrepareConnectButtons();
            this.helpshiftManager = this;
            this.UpdateNotificationIcons(enable:  (this.helpshiftManager.messageCount > 0) ? 1 : 0);
            this.versionTextCounter = 0;
            this.versionText.enabled = false;
        }
        protected override void OnInitCompleted()
        {
            UnityEngine.Transform val_1 = this.center.transform;
            UnityEngine.Vector3 val_2 = val_1.position;
            this.center.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_1.BottomYPositionOfTopUi() + (-6.75f), z = val_2.z};
        }
        public override void OnActivate()
        {
            this.OnActivate();
            this.HighlightNotification(highlight:  true);
        }
        private void InitForAppleLogin()
        {
            if(Royal.Infrastructure.Services.Login.AppleConnect.IsSupported() == false)
            {
                    return;
            }
            
            this.appleButton.SetActive(value:  true);
            UnityEngine.Vector3 val_3 = this.buttonBlock.transform.localPosition;
            this.buttonBlock.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = 0.65f, z = val_3.z};
        }
        private void OnMusicToggle(bool active)
        {
            if(this.audioManager != null)
            {
                    if(active != false)
            {
                    this.audioManager.UnmuteMusic();
                return;
            }
            
                this.audioManager.MuteMusic();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnSfxToggle(bool active)
        {
            if(this.audioManager != null)
            {
                    if(active != false)
            {
                    this.audioManager.UnmuteSfx();
                return;
            }
            
                this.audioManager.MuteSfx();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnHintToggle(bool active)
        {
            if(this.hintManager != null)
            {
                    if(active != false)
            {
                    this.hintManager.EnableHintInSettings();
                return;
            }
            
                this.hintManager.DisableHintInSettings();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnNotificationToggle(bool active)
        {
            if(this.notificationToggleTriggeredInternally != false)
            {
                    this.notificationToggleTriggeredInternally = false;
                return;
            }
            
            if(active == false)
            {
                goto label_3;
            }
            
            this.gameNotificationService.EnableNotificationInGameSettings();
            if(this.gameNotificationService.IsNotificationEnabledInDeviceSettings() == true)
            {
                    return;
            }
            
            this.notificationToggleTriggeredInternally = true;
            this.notificationToggle.Toggle(enable:  false);
            if(((Royal.Infrastructure.Utils.Native.DeviceHelper.IsIos == false) || ((Royal.Infrastructure.Contexts.Units.App.AppManager.<SessionCount>k__BackingField) != 1)) || ((Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetBool(key:  "RequestNotificationPermission", defaultValue:  false)) == false))
            {
                goto label_10;
            }
            
            this.gameNotificationService.RequestPermissionAndInitializeOneSignal();
            return;
            label_3:
            this.gameNotificationService.DisableNotificationInGameSettings();
            return;
            label_10:
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.RequestNotification.ShowRequestNotificationDialogAction());
        }
        public void ShowHelpshift()
        {
            if(HasSupportBan != false)
            {
                    return;
            }
            
            this.helpshiftManager.Show();
        }
        public void ShowVersion()
        {
            int val_5 = this.versionTextCounter;
            val_5 = val_5 + 1;
            this.versionTextCounter = val_5;
            if(val_5 < 3)
            {
                    return;
            }
            
            this.versionTextCounter = 0;
            this.versionText.enabled = (~this.versionText.enabled) & 1;
            this = this.versionText;
            this.text = UnityEngine.Application.version + "  / "("  / ") + Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name;
        }
        public override void OnDeactivate()
        {
            this.OnDeactivate();
            this.HighlightNotification(highlight:  false);
            this.versionTextCounter = 0;
            this.versionText.enabled = false;
        }
        public void UpdateNotificationIcons(bool enable)
        {
            bool val_1 = enable;
            this.supportNotification.SetActive(value:  val_1);
            this.settingsNotification.SetActive(value:  val_1);
        }
        public void ToggleFacebookConnect()
        {
            .<>4__this = this;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            .flowManager = val_2;
            val_2.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.NoConnection.InternetConnectionAction(shouldCheckMaintenance:  true, onInternetConnection:  new System.Action(object:  new SettingsSection.<>c__DisplayClass32_0(), method:  System.Void SettingsSection.<>c__DisplayClass32_0::<ToggleFacebookConnect>b__0()), onComplete:  0));
        }
        public void ToggleAppleConnect()
        {
            .<>4__this = this;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            .flowManager = val_2;
            val_2.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.NoConnection.InternetConnectionAction(shouldCheckMaintenance:  true, onInternetConnection:  new System.Action(object:  new SettingsSection.<>c__DisplayClass33_0(), method:  System.Void SettingsSection.<>c__DisplayClass33_0::<ToggleAppleConnect>b__0()), onComplete:  0));
        }
        private void PrepareConnectButtons()
        {
            this.facebookButtonText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  ((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsConnectedFacebook()) != true) ? "FacebookSignOut" : "FacebookSignIn");
            this.appleButtonText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  ((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsConnectedApple()) != true) ? "AppleSignOut" : "AppleSignIn");
        }
        private void OnLoginChange()
        {
            this.PrepareConnectButtons();
        }
        private void OnDeviceNotificationSettingsChange()
        {
            this.notificationToggleTriggeredInternally = true;
            this.notificationToggle.Toggle(enable:  this.gameNotificationService.IsNotificationEnabled());
        }
        private void OnDestroy()
        {
            this.helpshiftManager = 0;
            this.loginService.remove_OnLoginChange(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Settings.SettingsSection::OnLoginChange()));
            this.gameNotificationService.remove_OnDeviceNotificationSettingsChange(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Settings.SettingsSection::OnDeviceNotificationSettingsChange()));
        }
        private void HighlightNotification(bool highlight)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  (highlight != true) ? 0.74f : 0.85f);
            this.settingsNotification.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public SettingsSection()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
