using UnityEngine;

namespace Royal.Infrastructure.Services.Login
{
    public class LoginService : IContextUnit
    {
        // Fields
        public const byte SettingsOrigin = 0;
        public const byte LeaderboardOrigin = 1;
        public const byte FacebookConnect = 1;
        public const byte AppleConnect = 2;
        private System.Action OnLoginChange;
        private System.Action<long> OnFbPictureDownloaded;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private Royal.Infrastructure.Services.Backend.Http.BackendHttpService backendHttpService;
        private Royal.Infrastructure.Services.Login.ISocialConnect appleConnect;
        private readonly Royal.Infrastructure.Services.Login.ISocialConnect facebookConnect;
        private int originType;
        private int timeOffset;
        private bool shouldShowResultDialog;
        private Royal.Infrastructure.Services.Login.ISocialConnect selectedPlatform;
        
        // Properties
        public int Id { get; }
        public bool ConnectionInProgress { get; }
        
        // Methods
        public void add_OnLoginChange(System.Action value)
        {
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  this.OnLoginChange, b:  value);
            }
            while(this.OnLoginChange != 1152921528356126672);
        
        }
        public void remove_OnLoginChange(System.Action value)
        {
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  this.OnLoginChange, value:  value);
            }
            while(this.OnLoginChange != 1152921528356263248);
        
        }
        public void add_OnFbPictureDownloaded(System.Action<long> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnFbPictureDownloaded, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnFbPictureDownloaded != 1152921528356399832);
            
            return;
            label_2:
        }
        public void remove_OnFbPictureDownloaded(System.Action<long> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnFbPictureDownloaded, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnFbPictureDownloaded != 1152921528356536408);
            
            return;
            label_2:
        }
        public int get_Id()
        {
            return 20;
        }
        public bool get_ConnectionInProgress()
        {
            if(this.selectedPlatform == null)
            {
                    return false;
            }
            
            var val_2 = 0;
            if(mem[1152921505135476736] != null)
            {
                    val_2 = val_2 + 1;
                return this.selectedPlatform.ConnectionInProgress;
            }
            
            var val_3 = mem[1152921505135476744];
            val_3 = val_3 + 4;
            Royal.Infrastructure.Services.Login.ISocialConnect val_1 = 1152921505135439872 + val_3;
            return this.selectedPlatform.ConnectionInProgress;
        }
        public LoginService()
        {
            Royal.Infrastructure.Services.Login.FacebookConnect val_1 = new Royal.Infrastructure.Services.Login.FacebookConnect();
            .loginService = this;
            val_1.Init();
            this.facebookConnect = val_1;
        }
        public void Bind()
        {
            this.appleConnect = new Royal.Infrastructure.Services.Login.AppleConnect();
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            this.backendHttpService = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7);
        }
        public void ConnectWithApple()
        {
            this.originType = 0;
            this.PlatformConnect(platform:  this.appleConnect);
        }
        public void ConnectWithFacebook(int origin = -1)
        {
            if(origin != 1)
            {
                    this.originType = origin;
            }
            
            this.PlatformConnect(platform:  this.facebookConnect);
        }
        public void DisconnectWithApple()
        {
            this.PlatformDisconnect(platform:  this.appleConnect);
        }
        public void DisconnectWithFacebook()
        {
            this.PlatformDisconnect(platform:  this.facebookConnect);
        }
        public void ShowResultDialog()
        {
            if(this.shouldShowResultDialog == false)
            {
                    return;
            }
            
            this.shouldShowResultDialog = false;
            var val_4 = 0;
            if(mem[1152921505135476736] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    Royal.Infrastructure.Services.Login.ISocialConnect val_1 = 1152921505135439872 + ((mem[1152921505135476744]) << 4);
            }
            
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.SocialConnect.ShowSocialConnectResultDialogAction(platform:  this.selectedPlatform.Type, success:  true, isConnect:  true));
        }
        public void FbPictureDownloaded(long fbId)
        {
            if(this.OnFbPictureDownloaded == null)
            {
                    return;
            }
            
            this.OnFbPictureDownloaded.Invoke(obj:  fbId);
        }
        private void PlatformConnect(Royal.Infrastructure.Services.Login.ISocialConnect platform)
        {
            IntPtr val_6;
            this.selectedPlatform = platform;
            var val_5 = 0;
            if(mem[1152921505135476736] != null)
            {
                    val_5 = val_5 + 1;
            }
            else
            {
                    var val_6 = mem[1152921505135476744];
                val_6 = val_6 + 5;
                Royal.Infrastructure.Services.Login.ISocialConnect val_1 = 1152921505135439872 + val_6;
            }
            
            platform.ConnectionInProgress = true;
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            System.Action<System.Boolean> val_3 = null;
            val_6 = System.Void Royal.Infrastructure.Services.Login.LoginService::OnPlatformInitCompleted(bool isSuccess);
            val_3 = new System.Action<System.Boolean>(object:  this, method:  val_6);
            var val_7 = 0;
            if(mem[1152921505135476736] != null)
            {
                    val_7 = val_7 + 1;
                val_6 = 6;
            }
            else
            {
                    var val_8 = mem[1152921505135476744];
                val_8 = val_8 + 6;
                Royal.Infrastructure.Services.Login.ISocialConnect val_4 = 1152921505135439872 + val_8;
            }
            
            this.selectedPlatform.Connect(onComplete:  val_3);
        }
        private void OnPlatformInitCompleted(bool isSuccess)
        {
            if(isSuccess != false)
            {
                    System.Action val_2 = static_value_02DC1B30;
                val_2 = new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Login.LoginService::<OnPlatformInitCompleted>b__31_0());
                Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(id:  21).ShowLoading(onComplete:  val_2, showSplash:  true, forceCreateNewSplash:  false);
                return;
            }
            
            if(this.OnLoginChange != null)
            {
                    this.OnLoginChange.Invoke();
            }
            
            var val_8 = 0;
            if(mem[1152921505135476736] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    var val_9 = mem[1152921505135476744];
                val_9 = val_9 + 5;
                Royal.Infrastructure.Services.Login.ISocialConnect val_3 = 1152921505135439872 + val_9;
            }
            
            this.selectedPlatform.ConnectionInProgress = false;
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            var val_10 = 0;
            if(mem[1152921505135476736] != null)
            {
                    val_10 = val_10 + 1;
            }
            else
            {
                    Royal.Infrastructure.Services.Login.ISocialConnect val_5 = 1152921505135439872 + ((mem[1152921505135476744]) << 4);
            }
            
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.SocialConnect.ShowSocialConnectResultDialogAction(platform:  this.selectedPlatform.Type, success:  false, isConnect:  true));
        }
        private void OnPlatformConnectCompleted(bool isSuccess)
        {
            if(isSuccess != false)
            {
                    this.SendUserConnectRequest();
                return;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(id:  21).HideLoading(delay:  0.5f);
            this.OnPlatformInitCompleted(isSuccess:  false);
        }
        private void SendUserConnectRequest()
        {
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_1 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            var val_10 = 0;
            if(mem[1152921505135476736] != null)
            {
                    val_10 = val_10 + 1;
            }
            else
            {
                    Royal.Infrastructure.Services.Login.ISocialConnect val_2 = 1152921505135439872 + ((mem[1152921505135476744]) << 4);
            }
            
            var val_11 = 0;
            if(mem[1152921505135476736] != null)
            {
                    val_11 = val_11 + 1;
            }
            else
            {
                    var val_12 = mem[1152921505135476744];
                val_12 = val_12 + 1;
                Royal.Infrastructure.Services.Login.ISocialConnect val_4 = 1152921505135439872 + val_12;
            }
            
            var val_13 = 0;
            if(mem[1152921505135476736] != null)
            {
                    val_13 = val_13 + 1;
            }
            else
            {
                    var val_14 = mem[1152921505135476744];
                val_14 = val_14 + 2;
                Royal.Infrastructure.Services.Login.ISocialConnect val_6 = 1152921505135439872 + val_14;
            }
            
            val_1.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.SocialConnectHttpCommand(platform:  this.selectedPlatform.Type, userId:  this.selectedPlatform.UserId, name:  this.selectedPlatform.UserName));
            val_1.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Infrastructure.Services.Login.LoginService::UserConnectResponseReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)));
            this.backendHttpService.SendImmediately(commandsToSend:  val_1, timeOut:  10f);
        }
        private void UserConnectResponseReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            var val_4;
            var val_11;
            var val_12;
            int val_13;
            FlatBuffers.ByteBuffer val_14;
            var val_15;
            long val_16;
            int val_17;
            Royal.Infrastructure.Services.Login.ISocialConnect val_18;
            val_11 = isSuccess;
            if(val_11 == false)
            {
                goto label_24;
            }
            
            Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand val_1 = container.FindCommandByType(responseType:  6);
            val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  14, log:  "Social platform connect status from backend: "("Social platform connect status from backend: ") + ???(???), values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if(48 > 5)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            if((0 & 21) != 0)
            {
                goto label_17;
            }
            
            val_13 = ???;
            val_14 = ???;
            val_15 = 0;
            val_16 = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name;
            val_17 = typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14;
            val_18 = 0;
            goto label_18;
            label_17:
            if((0 & 40) == 0)
            {
                    Royal.Infrastructure.Contexts.Units.App.AppManager val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
                val_3.consentHelper.InitConsent(newInstall:  false);
            }
            
            if(val_4 == false)
            {
                goto label_24;
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).ChangeUserToBackendDecidedUser(id:  null, token:  ???, syncId:  -2018122448, progress:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.UserProgress>() {HasValue = false});
            UpdateAbTestData(userId:  null, newAbTestData:  null, newAbTestUpdateData:  null, abTestContent:  new System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.ABTestContent>() {HasValue = true});
            val_13 = ???;
            val_14 = ???;
            val_15 = 1;
            val_16 = Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name;
            val_17 = typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14;
            val_18 = this.GetDisconnectedPlatform();
            label_18:
            this.UserConnected(userChanged:  true, oldUserId:  val_16, oldUserLevel:  val_17, rawResponse:  new Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse() {__p = new FlatBuffers.Table() {bb_pos = val_13, bb = val_14}}, disconnectedPlatform:  val_18);
            return;
            label_24:
            this.OnPlatformConnectCompleted(isSuccess:  false);
        }
        private Royal.Infrastructure.Services.Login.ISocialConnect GetDisconnectedPlatform()
        {
            if(this.selectedPlatform == null)
            {
                    return 0;
            }
            
            do
            {
                return 0;
            }
            while(this.selectedPlatform != null);
            
            return 0;
        }
        private void UserConnectFailed()
        {
            this.OnPlatformConnectCompleted(isSuccess:  false);
        }
        private void UserConnected(bool userChanged, long oldUserId, int oldUserLevel, Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse rawResponse, Royal.Infrastructure.Services.Login.ISocialConnect disconnectedPlatform)
        {
            var val_12;
            var val_11 = 0;
            if(mem[1152921505135476736] != null)
            {
                    val_11 = val_11 + 1;
            }
            else
            {
                    var val_12 = mem[1152921505135476744];
                val_12 = val_12 + 8;
                Royal.Infrastructure.Services.Login.ISocialConnect val_1 = 1152921505135439872 + val_12;
            }
            
            this.selectedPlatform.Connected(rawResponse:  new Royal.Infrastructure.Services.Backend.Protocol.SocialConnectResponse() {__p = new FlatBuffers.Table() {bb_pos = rawResponse.__p.bb_pos, bb = rawResponse.__p.bb}});
            if(disconnectedPlatform != null)
            {
                    this.SendDisconnectEvent(platform:  disconnectedPlatform, oldUserId:  oldUserId, oldUserLevel:  oldUserLevel);
            }
            
            var val_13 = 0;
            if(mem[1152921505135476736] != null)
            {
                    val_13 = val_13 + 1;
            }
            else
            {
                    var val_14 = mem[1152921505135476744];
                val_14 = val_14 + 3;
                Royal.Infrastructure.Services.Login.ISocialConnect val_3 = 1152921505135439872 + val_14;
            }
            
            var val_15 = 0;
            if(mem[1152921505135476736] != null)
            {
                    val_15 = val_15 + 1;
            }
            else
            {
                    var val_16 = mem[1152921505135476744];
                val_16 = val_16 + 1;
                Royal.Infrastructure.Services.Login.ISocialConnect val_5 = 1152921505135439872 + val_16;
            }
            
            int val_7 = this.timeOffset + 1;
            this.timeOffset = val_7;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).SocialConnection(typePrefix:  this.selectedPlatform.AnalyticsTypePrefix, isConnect:  true, triggerId:  this.originType, oldUserId:  oldUserId, oldUserLevel:  oldUserLevel, platformId:  this.selectedPlatform.UserId, timeOffset:  val_7);
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_8 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            val_12 = 0;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(id:  21).HideLoading(delay:  0.5f);
            this.shouldShowResultDialog = true;
            if(userChanged != true)
            {
                    this.ShowResultDialog();
            }
            
            if(this.OnLoginChange != null)
            {
                    this.OnLoginChange.Invoke();
            }
            
            var val_17 = 0;
            if(mem[1152921505135476736] != null)
            {
                    val_17 = val_17 + 1;
                val_12 = 5;
            }
            else
            {
                    var val_18 = mem[1152921505135476744];
                val_18 = val_18 + 5;
                Royal.Infrastructure.Services.Login.ISocialConnect val_10 = 1152921505135439872 + val_18;
            }
            
            this.selectedPlatform.ConnectionInProgress = false;
        }
        private void PlatformDisconnect(Royal.Infrastructure.Services.Login.ISocialConnect platform)
        {
            Royal.Infrastructure.Services.Login.ISocialConnect val_10;
            this.selectedPlatform = platform;
            val_10 = this.selectedPlatform;
            var val_11 = 0;
            if(mem[1152921505135476736] != null)
            {
                    val_11 = val_11 + 1;
            }
            else
            {
                    var val_12 = mem[1152921505135476744];
                val_12 = val_12 + 9;
                Royal.Infrastructure.Services.Login.ISocialConnect val_1 = 1152921505135439872 + val_12;
            }
            
            val_10.Disconnect();
            long val_2 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetLong(key:  "GuestId", defaultValue:  0);
            if(val_2 == 0)
            {
                goto label_10;
            }
            
            val_10 = val_2;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsConnectedToAnyPlatform()) == false)
            {
                goto label_11;
            }
            
            label_10:
            this.SendDisconnectEvent(platform:  this.selectedPlatform, oldUserId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name, oldUserLevel:  typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14);
            var val_13 = 0;
            if(mem[1152921505135476736] == null)
            {
                goto label_14;
            }
            
            val_13 = val_13 + 1;
            goto label_16;
            label_11:
            this.SendDisconnectEvent(platform:  this.selectedPlatform, oldUserId:  val_10, oldUserLevel:  typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14);
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).ChangeUserToLocalOldUser(guestId:  val_10, guestToken:  Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetString(key:  "GuestToken", defaultValue:  System.String.alignConst));
            System.Action val_7 = static_value_02DC1B30;
            val_7 = new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.Login.LoginService::<PlatformDisconnect>b__38_0());
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(id:  21).ShowLoading(onComplete:  val_7, showSplash:  true, forceCreateNewSplash:  false);
            return;
            label_14:
            Royal.Infrastructure.Services.Login.ISocialConnect val_8 = 1152921505135439872 + ((mem[1152921505135476744]) << 4);
            label_16:
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.SocialConnect.ShowSocialConnectResultDialogAction(platform:  this.selectedPlatform.Type, success:  true, isConnect:  false));
            if(this.OnLoginChange == null)
            {
                    return;
            }
            
            this.OnLoginChange.Invoke();
        }
        private void SendDisconnectEvent(Royal.Infrastructure.Services.Login.ISocialConnect platform, long oldUserId, int oldUserLevel)
        {
            var val_5 = 0;
            if(mem[1152921505135476736] != null)
            {
                    val_5 = val_5 + 1;
            }
            else
            {
                    var val_6 = mem[1152921505135476744];
                val_6 = val_6 + 3;
                Royal.Infrastructure.Services.Login.ISocialConnect val_2 = 1152921505135439872 + val_6;
            }
            
            int val_4 = this.timeOffset + 1;
            this.timeOffset = val_4;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).SocialConnection(typePrefix:  platform.AnalyticsTypePrefix, isConnect:  false, triggerId:  0, oldUserId:  oldUserId, oldUserLevel:  oldUserLevel, platformId:  "0", timeOffset:  val_4);
        }
        private void ReturnToGuestFinished(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            var val_3;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(id:  21).HideLoading(delay:  0.5f);
            if(isSuccess != true)
            {
                    val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  8, log:  "User disconnected but couldn\'t get last state from backend.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            }
            
            if(this.OnLoginChange != null)
            {
                    this.OnLoginChange.Invoke();
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).ForceLoadHomeSceneWhenPossible();
        }
        private void <OnPlatformInitCompleted>b__31_0()
        {
            IntPtr val_3;
            System.Action<System.Boolean> val_1 = null;
            val_3 = System.Void Royal.Infrastructure.Services.Login.LoginService::OnPlatformConnectCompleted(bool isSuccess);
            val_1 = new System.Action<System.Boolean>(object:  this, method:  val_3);
            var val_3 = 0;
            if(mem[1152921505135476736] != null)
            {
                    val_3 = val_3 + 1;
                val_3 = 7;
            }
            else
            {
                    var val_4 = mem[1152921505135476744];
                val_4 = val_4 + 7;
                Royal.Infrastructure.Services.Login.ISocialConnect val_2 = 1152921505135439872 + val_4;
            }
            
            this.selectedPlatform.PrepareRequiredData(onComplete:  val_1);
        }
        private void <PlatformDisconnect>b__38_0()
        {
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_1 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasToken) != true)
            {
                    val_1.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.RegisterHttpCommand());
            }
            
            val_1.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.PingHttpCommand());
            val_1.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Infrastructure.Services.Login.LoginService::ReturnToGuestFinished(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_1, timeOut:  10f);
        }
    
    }

}
