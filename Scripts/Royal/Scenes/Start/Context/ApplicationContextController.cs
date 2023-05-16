using UnityEngine;

namespace Royal.Scenes.Start.Context
{
    public class ApplicationContextController : MonoBehaviour
    {
        // Fields
        private const int MaxRegisterTryCount = 10;
        public Royal.Scenes.Start.Context.Units.Loading.View.SplashView splashView;
        public UnityEngine.AudioSource musicSource;
        public UnityEngine.AudioSource soundSource;
        private Royal.Infrastructure.Contexts.Units.App.AppManager appManager;
        private bool alreadyPaused;
        private int registerTryCount;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
            Royal.Scenes.Start.Context.ApplicationContextController.ConfigureApplication();
        }
        private static void ConfigureApplication()
        {
            UnityEngine.Application.targetFrameRate = 60;
            UnityEngine.QualitySettings.vSyncCount = 0;
            UnityEngine.Input.multiTouchEnabled = false;
            Royal.Infrastructure.Services.Localization.LocalizationHelper.Initialize();
            Royal.Infrastructure.Services.Remote.FirebaseHelper.Initialize();
            Royal.Infrastructure.Services.Analytics.MarketingHelper.Initialize();
        }
        private System.Collections.IEnumerator Start()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new ApplicationContextController.<Start>d__8();
        }
        private void InitContext()
        {
            Royal.Scenes.Start.Context.ApplicationContextController.AddLogService();
            Royal.Scenes.Start.Context.ApplicationContextController.AddCameraManager();
            this.AddLoadingManager();
            this.AddAppManager();
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(unit:  new Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Infrastructure.Services.Storage.DatabaseService>(unit:  new Royal.Infrastructure.Services.Storage.DatabaseService());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(unit:  new Royal.Infrastructure.Services.Backend.Http.TimeHelper());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Infrastructure.Utils.Randoming.RandomManager>(unit:  new Royal.Infrastructure.Utils.Randoming.RandomManager());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Scenes.Start.Context.Units.TweenManager>(unit:  new Royal.Scenes.Start.Context.Units.TweenManager());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(unit:  new Royal.Infrastructure.Services.Backend.Http.BackendHttpService());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Infrastructure.Services.Native.NativeService>(unit:  new Royal.Infrastructure.Services.Native.NativeService());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(unit:  new Royal.Scenes.Start.Context.Units.Flow.FlowManager());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(unit:  new Royal.Infrastructure.UiComponents.Dialog.DialogManager());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(unit:  new Royal.Infrastructure.UiComponents.Touch.UiTouchListener());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(unit:  new Royal.Scenes.Start.Context.Units.Audio.AudioManager());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(unit:  new Royal.Infrastructure.Services.Analytics.AnalyticsManager());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Infrastructure.Services.Remote.RemoteConfigManager>(unit:  new Royal.Infrastructure.Services.Remote.RemoteConfigManager());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Infrastructure.Services.Login.LoginService>(unit:  new Royal.Infrastructure.Services.Login.LoginService());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Infrastructure.Services.Notification.GameNotificationService>(unit:  new Royal.Infrastructure.Services.Notification.GameNotificationService());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper>(unit:  new Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager>(unit:  new Royal.Infrastructure.Services.AssetDownload.AreaDownloadManager());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Infrastructure.Services.AssetDownload.AudioDownloadManager>(unit:  new Royal.Infrastructure.Services.AssetDownload.AudioDownloadManager());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(unit:  new Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Player.Context.UserContext>(unit:  new Royal.Player.Context.UserContext());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Scenes.Home.Context.HomeContext>(unit:  new Royal.Scenes.Home.Context.HomeContext());
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Scenes.Game.Context.GameContext>(unit:  new Royal.Scenes.Game.Context.GameContext());
            Royal.Scenes.Start.Context.ApplicationContext.BindAll();
            object[] val_23 = new object[1];
            val_23[0] = I2.Loc.LocalizationManager.CurrentLanguage;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  1, log:  "ApplicationContext initialized ({0}).", values:  val_23);
        }
        private void AddAppManager()
        {
            Royal.Infrastructure.Contexts.Units.App.AppManager val_1 = new Royal.Infrastructure.Contexts.Units.App.AppManager();
            this.appManager = val_1;
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Infrastructure.Contexts.Units.App.AppManager>(unit:  val_1);
        }
        private static void AddLogService()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Infrastructure.Services.Logs.LogService>(unit:  new Royal.Infrastructure.Services.Logs.LogService());
            Royal.Infrastructure.Services.Logs.Log.Init();
        }
        private static void AddCameraManager()
        {
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = new Royal.Infrastructure.Contexts.Units.CameraManager();
            val_1.SetSceneCamera(camera:  UnityEngine.Camera.main);
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Infrastructure.Contexts.Units.CameraManager>(unit:  val_1);
        }
        private void AddLoadingManager()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Add<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(unit:  new Royal.Scenes.Start.Context.Units.Loading.LoadingManager(splash:  this.splashView));
        }
        private void StartApplication()
        {
            this.appManager.Start();
            this.appManager.consentHelper.Start(versionHelper:  this.appManager.versionHelper);
        }
        public static void OnConsentFinished(bool newInstall)
        {
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsIos != false)
            {
                    com.adjust.sdk.Adjust.requestTrackingAuthorizationWithCompletionHandler(statusCallback:  new System.Action<System.Int32>(object:  0, method:  static System.Void Royal.Scenes.Start.Context.ApplicationContextController::AppTrackingRequestCallback(int attStatus)), sceneName:  "Adjust");
            }
            
            bool val_3 = newInstall;
            Royal.Scenes.Start.Context.ApplicationContextController.CreateGameObjectPool(newInstall:  val_3);
            Royal.Scenes.Start.Context.ApplicationContextController.LoadNextScene(newInstall:  val_3);
        }
        private static void LoadNextScene(bool newInstall)
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).LoadHomeSceneFromStart();
        }
        private static void CreateGameObjectPool(bool newInstall)
        {
            System.Type val_6;
            var val_7;
            System.Object[] val_8;
            string val_9;
            var val_10;
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsLowEnd == false)
            {
                goto label_1;
            }
            
            val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184;
            val_9 = "Device is Low End, will create pools in gameplay scene.";
            goto label_10;
            label_1:
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory val_3 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            if((val_3.CreatePermanentPoolsFirstPart() < 750) || (newInstall == true))
            {
                goto label_13;
            }
            
            val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184;
            val_9 = "Pool creation second part will be done on level load.";
            label_10:
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  val_6, logTag:  1, log:  val_9, values:  val_8);
            return;
            label_13:
            val_3.CreatePermanentPoolsSecondPart();
        }
        private void Update()
        {
            Royal.Scenes.Start.Context.ApplicationContext.ManualUpdate();
        }
        private void OnApplicationPause(bool isPaused)
        {
            if(this.appManager == null)
            {
                    return;
            }
            
            if(isPaused != false)
            {
                    if(this.alreadyPaused == true)
            {
                    return;
            }
            
                this.alreadyPaused = true;
                this.appManager.ApplicationPaused();
                this.CancelRegisterUser();
                return;
            }
            
            if(this.alreadyPaused == false)
            {
                    return;
            }
            
            this.alreadyPaused = false;
            this.appManager.ApplicationResumed();
            this.TryRegisterUser();
        }
        private void OnApplicationFocus(bool hasFocus)
        {
            if(this.appManager == null)
            {
                    return;
            }
            
            if(this.appManager.consentHelper != null)
            {
                    if(this.appManager.consentHelper.requiresConsent != false)
            {
                    return;
            }
            
                hasFocus = (~hasFocus) & 1;
                this.OnApplicationPause(isPaused:  hasFocus);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnDestroy()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Clear();
        }
        private void TryRegisterUser()
        {
            this.InvokeRepeating(methodName:  "RegisterUser", time:  0f, repeatRate:  5f);
        }
        private void RegisterUser()
        {
            int val_3 = this.registerTryCount;
            val_3 = val_3 + 1;
            this.registerTryCount = val_3;
            if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).RegisterIfNeeded()) != false)
            {
                    if(this.registerTryCount < 11)
            {
                    return;
            }
            
            }
            
            this.CancelRegisterUser();
        }
        public bool IsTryingRegister()
        {
            int val_2 = this.registerTryCount;
            val_2 = val_2 - 1;
            return (bool)(val_2 < 10) ? 1 : 0;
        }
        private void CancelRegisterUser()
        {
            this.registerTryCount = 0;
            this.CancelInvoke(methodName:  "RegisterUser");
        }
        internal void StartWaitForConsentCoroutine(System.Action onConsentGiven)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.appManager.consentHelper.WaitForConsent(onConsentGiven:  onConsentGiven));
        }
        private static void AppTrackingRequestCallback(int attStatus)
        {
            Royal.Infrastructure.Services.Login.FacebookConnect.SetFbAdvertisingTrackingStatus(isEnabled:  (attStatus == 3) ? 1 : 0);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Notification.GameNotificationService>(id:  18).RequestPermissionIfRuleSatisfied();
        }
        public ApplicationContextController()
        {
        
        }
    
    }

}
