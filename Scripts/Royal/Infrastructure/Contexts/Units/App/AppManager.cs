using UnityEngine;

namespace Royal.Infrastructure.Contexts.Units.App
{
    public class AppManager : IContextUnit
    {
        // Fields
        private static float <CurrentSessionTime>k__BackingField;
        private static float <CurrentPausedTime>k__BackingField;
        private static int <FocusCount>k__BackingField;
        private static bool <IsPaused>k__BackingField;
        private static long <SessionCount>k__BackingField;
        public readonly Royal.Infrastructure.Contexts.Units.App.VersionHelper versionHelper;
        public readonly Royal.Infrastructure.Contexts.Units.App.ConsentHelper consentHelper;
        private System.Action OnApplicationStart;
        private System.Action OnApplicationPause;
        private System.Action OnApplicationResume;
        private System.Action OnApplicationQuit;
        private float pauseTime;
        private float sessionTime;
        
        // Properties
        public int Id { get; }
        public static string StoreUrl { get; }
        public static float CurrentSessionTime { get; set; }
        public static float CurrentPausedTime { get; set; }
        public static int FocusCount { get; set; }
        public static bool IsPaused { get; set; }
        public static long SessionCount { get; set; }
        
        // Methods
        public int get_Id()
        {
            return 3;
        }
        public static string get_StoreUrl()
        {
            return "market://details?id=com.dreamgames.royalmatch";
        }
        public static float get_CurrentSessionTime()
        {
            return (float)Royal.Infrastructure.Contexts.Units.App.AppManager.<CurrentSessionTime>k__BackingField;
        }
        private static void set_CurrentSessionTime(float value)
        {
            Royal.Infrastructure.Contexts.Units.App.AppManager.<CurrentSessionTime>k__BackingField = value;
        }
        public static float get_CurrentPausedTime()
        {
            return (float)Royal.Infrastructure.Contexts.Units.App.AppManager.<CurrentPausedTime>k__BackingField;
        }
        private static void set_CurrentPausedTime(float value)
        {
            Royal.Infrastructure.Contexts.Units.App.AppManager.<CurrentPausedTime>k__BackingField = value;
        }
        public static int get_FocusCount()
        {
            return (int)Royal.Infrastructure.Contexts.Units.App.AppManager.<FocusCount>k__BackingField;
        }
        private static void set_FocusCount(int value)
        {
            Royal.Infrastructure.Contexts.Units.App.AppManager.<FocusCount>k__BackingField = value;
        }
        public static bool get_IsPaused()
        {
            return (bool)Royal.Infrastructure.Contexts.Units.App.AppManager.<IsPaused>k__BackingField;
        }
        private static void set_IsPaused(bool value)
        {
            Royal.Infrastructure.Contexts.Units.App.AppManager.<IsPaused>k__BackingField = value;
        }
        public static long get_SessionCount()
        {
            return (long)Royal.Infrastructure.Contexts.Units.App.AppManager.<SessionCount>k__BackingField;
        }
        private static void set_SessionCount(long value)
        {
            Royal.Infrastructure.Contexts.Units.App.AppManager.<SessionCount>k__BackingField = value;
        }
        public void add_OnApplicationStart(System.Action value)
        {
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  this.OnApplicationStart, b:  value);
            }
            while(this.OnApplicationStart != 1152921528707268848);
        
        }
        public void remove_OnApplicationStart(System.Action value)
        {
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  this.OnApplicationStart, value:  value);
            }
            while(this.OnApplicationStart != 1152921528707405424);
        
        }
        public void add_OnApplicationPause(System.Action value)
        {
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  this.OnApplicationPause, b:  value);
            }
            while(this.OnApplicationPause != 1152921528707542008);
        
        }
        public void remove_OnApplicationPause(System.Action value)
        {
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  this.OnApplicationPause, value:  value);
            }
            while(this.OnApplicationPause != 1152921528707678584);
        
        }
        public void add_OnApplicationResume(System.Action value)
        {
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  this.OnApplicationResume, b:  value);
            }
            while(this.OnApplicationResume != 1152921528707815168);
        
        }
        public void remove_OnApplicationResume(System.Action value)
        {
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  this.OnApplicationResume, value:  value);
            }
            while(this.OnApplicationResume != 1152921528707951744);
        
        }
        public void add_OnApplicationQuit(System.Action value)
        {
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  this.OnApplicationQuit, b:  value);
            }
            while(this.OnApplicationQuit != 1152921528708088328);
        
        }
        public void remove_OnApplicationQuit(System.Action value)
        {
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  this.OnApplicationQuit, value:  value);
            }
            while(this.OnApplicationQuit != 1152921528708224904);
        
        }
        public AppManager()
        {
            this.versionHelper = new Royal.Infrastructure.Contexts.Units.App.VersionHelper();
            this.consentHelper = new Royal.Infrastructure.Contexts.Units.App.ConsentHelper();
        }
        public void Bind()
        {
            var val_6;
            this.versionHelper.UpdateVersion();
            val_6 = null;
            Royal.Infrastructure.Contexts.Units.App.AppManager.<SessionCount>k__BackingField = (Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetLong(key:  "SessionCount", defaultValue:  0)) + 1;
            val_6 = 1152921505146196152;
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetLong(key:  "SessionCount", value:  Royal.Infrastructure.Contexts.Units.App.AppManager.<SessionCount>k__BackingField);
            if((Royal.Infrastructure.Contexts.Units.App.AppManager.<SessionCount>k__BackingField) != 1)
            {
                    return;
            }
            
            bool val_5 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetLong(key:  "InstallTime", value:  Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs());
        }
        public void Start()
        {
            var val_2;
            this.sessionTime = UnityEngine.Time.time;
            this.versionHelper.Migrate();
            if(this.OnApplicationStart != null)
            {
                    this.OnApplicationStart.Invoke();
            }
            
            this.CheckCrashFlag();
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  0, log:  "======================= Started =====================", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void Clear()
        {
            var val_7;
            float val_8;
            var val_9;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  0, log:  "======================== Quiting =======================", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            val_8 = 0f;
            if(this.sessionTime > 0f)
            {
                    val_8 = UnityEngine.Mathf.Max(a:  0f, b:  UnityEngine.Time.time - this.sessionTime);
            }
            
            Royal.Infrastructure.Contexts.Units.App.AppManager.<CurrentSessionTime>k__BackingField = val_8;
            if(this.OnApplicationQuit != null)
            {
                    this.OnApplicationQuit.Invoke();
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  0).OnApplicationQuit();
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  4).OnApplicationQuit();
            object[] val_6 = new object[2];
            int val_7 = Royal.Infrastructure.Contexts.Units.App.AppManager.<FocusCount>k__BackingField;
            val_7 = val_7 + 1;
            val_6[0] = val_7;
            val_6[1] = Royal.Infrastructure.Contexts.Units.App.AppManager.<CurrentSessionTime>k__BackingField;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  0, log:  "{0}. session time is {1} seconds", values:  val_6);
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  0, log:  "======================== Quit =======================", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.OnApplicationPause = 0;
            this.OnApplicationResume = 0;
            this.OnApplicationQuit = 0;
            Royal.Infrastructure.Contexts.Units.App.AppManager.RemoveCrashFlag();
        }
        public void ApplicationPaused()
        {
            float val_9;
            float val_10;
            var val_11;
            var val_12;
            val_9 = 0f;
            Royal.Infrastructure.Contexts.Units.App.AppManager.<IsPaused>k__BackingField = true;
            val_10 = this.sessionTime;
            if(val_10 > 0f)
            {
                    val_10 = 0f;
                val_9 = UnityEngine.Mathf.Max(a:  val_10, b:  UnityEngine.Time.time - this.sessionTime);
            }
            
            Royal.Infrastructure.Contexts.Units.App.AppManager.<CurrentSessionTime>k__BackingField = val_9;
            object[] val_4 = new object[2];
            int val_9 = Royal.Infrastructure.Contexts.Units.App.AppManager.<FocusCount>k__BackingField;
            val_9 = val_9 + 1;
            val_4[0] = val_9;
            val_4[1] = Royal.Infrastructure.Contexts.Units.App.AppManager.<CurrentSessionTime>k__BackingField;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  0, log:  "{0}. session time is {1} seconds", values:  val_4);
            val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  0, log:  "====================== Pausing ======================", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsAndroid != false)
            {
                    this.versionHelper.TryCloseForceAlert();
            }
            
            if(this.OnApplicationPause != null)
            {
                    this.OnApplicationPause.Invoke();
            }
            
            this.consentHelper.OnApplicationPause();
            Royal.Player.Context.UserContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  0).OnApplicationPause();
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  4).OnApplicationPause();
            val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  0, log:  "====================== Paused ======================", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.pauseTime = UnityEngine.Time.realtimeSinceStartup;
            Royal.Infrastructure.Contexts.Units.App.AppManager.RemoveCrashFlag();
        }
        public void ApplicationResumed()
        {
            var val_9;
            var val_10;
            float val_11;
            var val_12;
            var val_13;
            Royal.Infrastructure.Contexts.Units.App.AppManager.AddCrashFlag();
            val_9 = null;
            Royal.Infrastructure.Contexts.Units.App.AppManager.<IsPaused>k__BackingField = false;
            val_9 = 1152921505146196152;
            val_10 = 1152921505146200072;
            Royal.Infrastructure.Contexts.Units.App.AppManager.<FocusCount>k__BackingField = (Royal.Infrastructure.Contexts.Units.App.AppManager.<FocusCount>k__BackingField) + 1;
            val_11 = 0f;
            this.sessionTime = UnityEngine.Time.time;
            if(this.pauseTime > 0f)
            {
                    val_11 = UnityEngine.Mathf.Max(a:  0f, b:  UnityEngine.Time.realtimeSinceStartup - this.pauseTime);
            }
            
            Royal.Infrastructure.Contexts.Units.App.AppManager.<CurrentPausedTime>k__BackingField = val_11;
            object[] val_6 = new object[2];
            val_6[0] = Royal.Infrastructure.Contexts.Units.App.AppManager.<FocusCount>k__BackingField;
            val_6[1] = Royal.Infrastructure.Contexts.Units.App.AppManager.<CurrentPausedTime>k__BackingField;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  0, log:  "{0}. pause time is {1} seconds", values:  val_6);
            val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  0, log:  "===================== Resuming =====================", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.consentHelper.OnApplicationResume();
            Royal.Player.Context.UserContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  0).OnApplicationResume();
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Storage.DatabaseService>(id:  4).OnApplicationResume();
            if(this.OnApplicationResume != null)
            {
                    this.OnApplicationResume.Invoke();
            }
            
            val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  0, log:  "===================== Resumed =====================", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void UpdateForceVersion(int version)
        {
            this.versionHelper.UpdateForceVersion(version:  version);
            this.versionHelper.CheckForceUpdate();
        }
        public void CheckForceUpdate()
        {
            if(this.versionHelper != null)
            {
                    this.versionHelper.CheckForceUpdate();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void CheckCrashFlag()
        {
            if((UnityEngine.PlayerPrefs.HasKey(key:  "CrashFlag")) != false)
            {
                    int val_2 = UnityEngine.PlayerPrefs.GetInt(key:  "CrashFlag");
                object[] val_3 = new object[1];
                val_3[0] = val_2;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  0, log:  "Crashed in previous session in scene: {0}", values:  val_3);
                if(val_2 == 2)
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LifeHelper>(id:  3).IncrementLives();
            }
            
                Firebase.Analytics.Parameter[] val_5 = new Firebase.Analytics.Parameter[1];
                val_5[0] = new Firebase.Analytics.Parameter(parameterName:  "memory", parameterValue:  (long)UnityEngine.SystemInfo.systemMemorySize);
                Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  "app_crashed", parameters:  val_5);
                return;
            }
            
            Royal.Infrastructure.Contexts.Units.App.AppManager.AddCrashFlag();
        }
        public static void AddCrashFlag()
        {
            UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            UnityEngine.PlayerPrefs.SetInt(key:  "CrashFlag", value:  val_1.m_Handle.buildIndex);
            UnityEngine.PlayerPrefs.Save();
        }
        private static void RemoveCrashFlag()
        {
            UnityEngine.PlayerPrefs.DeleteKey(key:  "CrashFlag");
            UnityEngine.PlayerPrefs.Save();
        }
    
    }

}
